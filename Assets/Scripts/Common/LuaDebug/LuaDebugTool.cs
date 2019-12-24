using System;
using System.Reflection;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using XLua;

[LuaCallCSharp]
public class LuaValueInfo
{
    public string name;
    public string valueType;
    public string valueStr;
    public bool isValue;
}

[LuaCallCSharp]
public class LuaDebugTool
{
    static private bool checkIsValue(Type valueType)
    {
        var isValue = false;
        if (
            valueType == typeof(System.Boolean) ||
            valueType == typeof(System.Byte) ||
            valueType == typeof(System.SByte) ||
            valueType == typeof(System.Char) ||
            valueType == typeof(System.Decimal) ||
            valueType == typeof(System.Double) ||
            valueType == typeof(System.Single) ||
            valueType == typeof(System.Int32) ||
            valueType == typeof(System.UInt32) ||
            valueType == typeof(System.Int64) ||
            valueType == typeof(System.UInt64) ||

            valueType == typeof(System.Int16) ||
            valueType == typeof(System.UInt16) ||
            valueType == typeof(System.String) ||
            valueType.IsEnum
            )
        {
            isValue = false;
        }
        else
        {
            isValue = true;
        }
        return isValue;
    }

    static public List<LuaValueInfo> getUserDataInfo(System.Object obj)
    {

        Type t = obj.GetType();
        List<LuaValueInfo> values = new List<LuaValueInfo>();
        //判断是否是数组
        if (t.IsArray)
        {
            Array array = (Array)obj;
            int i = 0;
            foreach (object j in array)
            {
                var value = j.ToString();
                values.Add(new LuaValueInfo()
                {
                    name = "[" + i + "]",
                    valueStr = value.ToString(),
                    valueType = value.GetType().ToString(),
                    isValue = checkIsValue(value.GetType())
                });
                i++;
            }
            return values;
        }
        if (t.IsGenericType)
        {
            int count = Convert.ToInt32(t.GetProperty("Count").GetValue(obj, null));
            for (int i = 0; i < count; i++)
            {
                object listItem = t.GetProperty("Item").GetValue(obj, new object[] { i });
                values.Add(new LuaValueInfo()
                {
                    name = "[" + i + "]",
                    valueStr = listItem.ToString(),
                    valueType = listItem.GetType().ToString(),
                    isValue = checkIsValue(listItem.GetType())
                });
            }
            return values;
        }


        PropertyInfo[] pinfos = t.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
        foreach (PropertyInfo pinfo in pinfos)
        {
            try
            {

                var value = pinfo.GetValue(obj, null);
                var valueType = value.GetType();

                values.Add(new LuaValueInfo()
                {
                    name = pinfo.Name,
                    valueStr = value.ToString(),
                    valueType = valueType.ToString(),
                    isValue = checkIsValue(valueType)
                });

            }
            catch (Exception e)
            {
                values.Add(new LuaValueInfo()
                {
                    name = pinfo.Name,
                    valueStr = "Null",
                    valueType = " ",
                    isValue = false
                });
            }

        }
        FieldInfo[] fields = t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);
        foreach (FieldInfo fi in fields)
        {
            try
            {
                string name = fi.Name;
                object value = fi.GetValue(obj);
                Type valueType = null;
                if (value == null)
                {
                    values.Add(new LuaValueInfo()
                    {
                        name = name,
                        valueStr = "Null",
                        valueType = " ",
                        isValue = false
                    });
                }
                else
                {
                    valueType = value.GetType();
                    values.Add(new LuaValueInfo()
                    {
                        name = name,
                        valueStr = value.ToString(),
                        valueType = valueType.ToString(),
                        isValue = checkIsValue(valueType)
                    });
                }
            }
            catch (Exception e)
            {
                var d = e.ToString();
            }
        }
        return values;
    }


}
