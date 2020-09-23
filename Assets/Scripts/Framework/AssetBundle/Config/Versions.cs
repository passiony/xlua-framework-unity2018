using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace AssetBundles
{
    public class Versions
    {
        private Dictionary<string, string> clientData = new Dictionary<string, string>();
        private Dictionary<string, string> serverData = new Dictionary<string, string>();
        private Dictionary<string, string> tempData = new Dictionary<string, string>();

        private Dictionary<string, int> BundleSize = new Dictionary<string, int>();

        private const char splitKey = '|';
        
        public IEnumerator LoadLocalVersions()
        {
            var versionsPath = AssetBundleUtility.GetPersistentDataPath(BuildUtils.VersionsFileName);
            var versionTxt= GameUtility.SafeReadAllText(versionsPath);
            if (string.IsNullOrEmpty(versionTxt))
            {
                var request = AssetBundleManager.Instance.RequestAssetFileAsync(BuildUtils.VersionsFileName);
                yield return request;
                versionTxt = request.text.Trim().Replace("\r", "");
                request.Dispose();

                LoadText2Map(versionTxt, ref clientData);
            }
            else
            {
                LoadText2Map(versionTxt, ref clientData);
            }
            LoadTempVersionHash();
        }
        
        private bool LoadTempVersionHash()
        {
            string versionTxt = GameUtility.SafeReadAllText(AssetBundleUtility.GetPersistentTempPath(BuildUtils.VersionsFileName));
            if (!string.IsNullOrEmpty(versionTxt))
            {
                LoadText2Map(versionTxt,ref tempData);
                return true;
            }
            return false;
        }

        public IEnumerator LoadServerVersion(bool isInternal=false)
        {
            var request = AssetBundleManager.Instance.DownloadAssetBundleAsync(BuildUtils.VersionsFileName);
            yield return request;
            
            if (isInternal && !string.IsNullOrEmpty(request.error))
            {
                UINoticeTip.Instance.ShowOneButtonTip("网络错误", "检测更新失败，请确认网络已经连接！", "重试", null);
                yield return UINoticeTip.Instance.WaitForResponse();
                Logger.LogError("Download host manifest :  " + request.assetbundleName + "\n from url : " + request.url + "\n err : " + request.error);
                request.Dispose();
                yield break;
            }

            var versionTxt = request.text.Trim().Replace("\r", "");
            request.Dispose();
            
            LoadText2SizeMap(versionTxt,ref serverData,ref BundleSize);
            yield break;
        }

        
        void LoadText2Map(string text, ref Dictionary<string, string> map)
        {
            map.Clear();
            if (string.IsNullOrEmpty(text)) 
                return;

            using (var reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var fields = line.Split(splitKey);
                    if (fields.Length > 1)
                    {
                        map.Add(fields[0], fields[1]);
                    }
                }
            }
        }
        
        void LoadText2SizeMap(string text, ref Dictionary<string, string> hashMap,ref Dictionary<string ,int> sizeMap)
        {
            hashMap.Clear();
            sizeMap.Clear();
            if (string.IsNullOrEmpty(text))
                return;

            using (var reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var fields = line.Split(splitKey);
                    if (fields.Length > 2)
                    {
                        hashMap.Add(fields[0], fields[1]);
                        sizeMap.Add(fields[0], int.Parse(fields[2]));
                    }
                }
            }
        }

        public int GetSize(string path)
        {
            if (BundleSize.TryGetValue(path, out int size))
            {
                return size;
            }

            return 0;
        }

        public int CompareVersions(ref List<string> updateList)
        {
            int size = 0;
            foreach (var item in serverData)
            {
                bool has1 = clientData.TryGetValue(item.Key, out string ver1);
                bool has2 = tempData.TryGetValue(item.Key, out string ver2);
                //Log.Warning(item.Key+"->"+item.Value+"|"+ver);
                if ((!has1 || !ver1.Equals(item.Value)) && (!has2 || !ver2.Equals(item.Value)))
                {
                    updateList.Add(item.Key);
                    size += GetSize(item.Key);
                }
            }

            if (updateList.Count > 0)
            {
                updateList.Add(BuildUtils.ManifestBundleName);
            }

            Debug.LogWarning(string.Format("updateList count = {0}", updateList.Count));
            return size;
        }

        public void SaveOneTempVersion(string bundleName)
        {
            if (serverData.TryGetValue(bundleName, out string md5))
            {
                tempData.Add(bundleName,md5);
            }
            
            SaveToDiskCahce(tempData);
        }

        public void SaveAllToTemp()
        {
            SaveToDiskCahce(serverData);
        }
        
        void SaveToDiskCahce(Dictionary<string,string> dict)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dict)
            {
                sb.AppendLine(string.Format("{0}|{1}", item.Key, item.Value));
            }
            
            //save to disk
            var versionsPath = AssetBundleUtility.GetPersistentTempPath(BuildUtils.VersionsFileName);
            GameUtility.SafeWriteAllText(versionsPath, sb.ToString());
        }
    }
}