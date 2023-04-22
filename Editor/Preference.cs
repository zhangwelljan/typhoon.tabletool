using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Typhoon.TableTool
{
    public class Preference : ScriptableObject
    {
        //配置文件
        private const string PREFERENCE_PATH = "Assets/Typhoon_Gen/TableTool/Editor/TableToolPreference.asset";


        //Addressable导出路径(json)
        public static string PATH_ADDRESSABLE_EXPORT_JSON =
            $"Assets/Typhoon_Gen/TableTool/Export/allInOne.json";

        //Addressable导出路径(bytes)
        public static string PATH_ADDRESSABLE_EXPORT_BYTES =
            $"Assets/Typhoon_Gen/TableTool/Export/allInOne.bytes";


        private static Preference _instance = null;

        public static Preference Instance
        {
            get
            {
                _instance = AssetDatabase.LoadAssetAtPath<Preference>(PREFERENCE_PATH);
                if (_instance == null)
                {
                    _instance = CreateInstance<Preference>();
                    FileInfo info = new FileInfo(PREFERENCE_PATH);
                    var folder = info.Directory.FullName;
                    if (!Directory.Exists(folder))
                    {
                        Directory.CreateDirectory(folder);
                    }

                    AssetDatabase.Refresh();
                    AssetDatabase.CreateAsset(_instance, PREFERENCE_PATH);
                    AssetDatabase.Refresh();
                }

                return _instance;
            }
        }


        [Header("偏好设置")] [Tooltip("加载方式")] public LoadMode LoadMode = LoadMode.Resource;

        //是否使用base64
        [Tooltip("文件类型")] public JsonFileType FileType = JsonFileType.Json;

        //使用自定义加载路径
        public bool UseCustomLoadPath = false;

        //AddressableGroup
        public string AddressableGroupGuid;

        //加载路径
        public string Address;
    }
}