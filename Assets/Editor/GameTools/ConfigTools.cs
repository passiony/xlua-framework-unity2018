using UnityEngine;
using UnityEditor;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;

/// <summary>
/// modify by zfc @ 2018.11.16
/// 说明：此处xlsx生成lua 以及proto 生成lua配置工具
/// 如果生成失败 配置下protobuf环境 已经python环境 备注：python版本最好是2 以及安装读取excel库 xlrd
/// </summary>

public class ConfigTools : EditorWindow
{
    private static string xlsxFolder = string.Empty;
    private static string protoFolder = string.Empty;

    private bool xlsxGenLuaFinished = false;
    private bool protoGenLuaFinished = false;

    void OnEnable()
    {
        ReadPath();
    }

    [MenuItem("Tools/LuaConfig")]
    static void Init()
    {
        GetWindow(typeof(ConfigTools));
        ReadPath();
    }

    private void OnGUI()
    {
        GUILayout.Space(10);
        GUILayout.BeginHorizontal();
        GUILayout.Label("xlsx path : ", EditorStyles.boldLabel, GUILayout.Width(80));
        xlsxFolder = GUILayout.TextField(xlsxFolder, GUILayout.Width(300));
        if (GUILayout.Button("...", GUILayout.Width(40)))
        {
            SelectXlsxFolder();
        }
        GUILayout.EndHorizontal();

        GUILayout.Space(10);
        GUILayout.BeginHorizontal();
        GUILayout.Label("proto path : ", EditorStyles.boldLabel, GUILayout.Width(80));
        protoFolder = GUILayout.TextField(protoFolder, GUILayout.Width(300));
        if (GUILayout.Button("...", GUILayout.Width(40)))
        {
            SelectProtoFolder();
        }
        GUILayout.EndHorizontal();

        GUILayout.Space(20);
        GUILayout.BeginHorizontal();
        GUILayout.Label("---------------------");
        if (GUILayout.Button("xlsx gen lua", GUILayout.Width(100)))
        {
            XlsxGenLua();
        }
        GUILayout.Space(40);
        GUILayout.Label("---------------------");
        GUILayout.EndHorizontal();

        GUILayout.Space(20);
        GUILayout.BeginHorizontal();
        GUILayout.Label("---------------------");
        if (GUILayout.Button("proto gen lua", GUILayout.Width(100)))
        {
            ProtoGenLua();
        }
        GUILayout.Space(40);
        GUILayout.Label("---------------------");
        GUILayout.EndHorizontal();
    }

    static int count = 0;
    static List<string> files = new List<string>();
    static List<string> exported = new List<string>();

    private void XlsxGenLua()
    {
        if (!CheckXlsxPath(xlsxFolder))
        {
            return;
        }

        files.Clear();
        exported.Clear();

        GetFilter(xlsxFolder + "/excel", "*.xlsx");

        foreach (var item in files)
        {
            string fileName = Path.GetFileNameWithoutExtension(item);

            Process p = new Process();
            p.StartInfo.FileName = "python";
            p.StartInfo.Arguments = string.Format("excel2lua.py excel/{0}.xlsx lua/{0}.lua", fileName);
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WorkingDirectory = xlsxFolder;
            p.Start();
            p.BeginOutputReadLine();
            p.OutputDataReceived += new DataReceivedEventHandler((object sender, DataReceivedEventArgs e) =>
            {
                if (!string.IsNullOrEmpty(e.Data))
                {
                    UnityEngine.Debug.Log(e.Data);
                    if (e.Data.Contains("exported"))
                    {
                        exported.Add(fileName);
                        Process pr = sender as Process;
                        if (pr != null)
                        {
                            pr.Close();
                        }
                        if (exported.Count == files.Count)
                            xlsxGenLuaFinished = true;
                    }
                }
            });
        }
    }

    private void ProtoGenLua()
    {
        if (!CheckProtoPath(protoFolder))
        {
            return;
        }

        Process p = new Process();
        p.StartInfo.FileName = protoFolder + "/make_proto.bat";
        p.StartInfo.Arguments = "";
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardInput = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.WorkingDirectory = protoFolder;
        p.Start();
        p.BeginOutputReadLine();
        p.OutputDataReceived += new DataReceivedEventHandler((object sender, DataReceivedEventArgs e) =>
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                UnityEngine.Debug.Log(e.Data);
                if (e.Data.Contains("DONE"))
                {
                    Process pr = sender as Process;
                    if (pr != null)
                    {
                        pr.Close();
                    }
                    protoGenLuaFinished = true;
                }
            }
        });
    }

    void Update()
    {
        if (protoGenLuaFinished)
        {
            protoGenLuaFinished = false;
            AssetDatabase.Refresh();
            EditorUtility.DisplayDialog("Succee", "Proto gen lua finished!", "Conform");
        }

        if (xlsxGenLuaFinished)
        {
            xlsxGenLuaFinished = false;

            // copy files
            string destPath = Application.dataPath + "/LuaScripts/Config/Data";
            if (Directory.Exists(destPath))
            {
                Directory.Delete(destPath, true);
            }
            Directory.CreateDirectory(destPath);

            string[] luaFiles = Directory.GetFiles(xlsxFolder + "/lua");
            foreach (var oneFile in luaFiles)
            {
                string destFileName = Path.Combine(destPath, Path.GetFileName(oneFile));
                UnityEngine.Debug.Log("Copy To: " + destFileName);
                File.Copy(oneFile, destFileName, true);
            }

            AssetDatabase.Refresh();

            string content = exported.Count + " Xlsx gen lua finished!\n\n";
            foreach (var item in exported)
            {
                content += "-->" + item + "\n";
            }
            EditorUtility.DisplayDialog("Succee", content, "Conform");
        }
    }

    private bool CheckXlsxPath(string xlsxPath)
    {
        if (string.IsNullOrEmpty(xlsxPath))
        {
            return false;
        }

        if (!File.Exists(xlsxPath + "/trans2lua.bat"))
        {
            EditorUtility.DisplayDialog("Error", "Err path :\nNo find ./trans2lua.bat", "Conform");
            return false;
        }

        return true;
    }

    private bool CheckProtoPath(string protoPath)
    {
        if (string.IsNullOrEmpty(protoPath))
        {
            return false;
        }

        if (!File.Exists(protoPath + "/make_proto.bat"))
        {
            EditorUtility.DisplayDialog("Error", "Err path :\nNo find ./make_proto.bat", "Conform");
            return false;
        }

        return true;
    }

    private void SelectXlsxFolder()
    {
        var selXlsxPath = EditorUtility.OpenFolderPanel("Select xlsx folder", "", "");
        if (!CheckXlsxPath(selXlsxPath))
        {
            return;
        }

        xlsxFolder = selXlsxPath;
        SavePath();
    }

    private void SelectProtoFolder()
    {
        var selProtoPath = EditorUtility.OpenFolderPanel("Select proto folder", "", "");
        if (!CheckProtoPath(selProtoPath))
        {
            return;
        }

        protoFolder = selProtoPath;
        SavePath();
    }

    static private void SavePath()
    {
        EditorPrefs.SetString("xlsxFolder", xlsxFolder);
        EditorPrefs.SetString("protoFolder", protoFolder);
    }

    static private void ReadPath()
    {
        xlsxFolder = EditorPrefs.GetString("xlsxFolder");
        protoFolder = EditorPrefs.GetString("protoFolder");
    }

    /// <summary>
    /// 遍历目录及其子目录
    /// </summary>
    static void GetFilter(string path, string searchPattern)
    {
        string[] names = Directory.GetFiles(path, searchPattern);
        string[] dirs = Directory.GetDirectories(path);

        foreach (string filename in names)
        {
            string ext = Path.GetExtension(filename);
            if (ext.Equals(".meta"))
                continue;

            FileInfo file = new FileInfo(filename);
            if ((file.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                continue;

            files.Add(filename.Replace('\\', '/'));
        }
        foreach (string dir in dirs)
        {
            GetFilter(dir, searchPattern);
        }
    }
}
