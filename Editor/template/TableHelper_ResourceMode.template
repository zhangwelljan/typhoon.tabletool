using System;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Typhoon.TableTool;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 配置表工具类
    /// </summary>
    public class TableHelper
    {
        private static AllTables _allTables = null;

        public static AllTables AllTables
        {
            get
            {
                if (_allTables == null)
                {
                    if (!Application.isPlaying)
                    {
#if UNITY_EDITOR
                        //如果在非运行状态下，从AssetDatabase加载
                        LoadFromAssetDatabase();
#endif
                    }
                    else
                    {
                        //尝试构建
                        Build();
                    }
                }

                if (_allTables == null)
                {
                    throw new Exception("TableTool未构建,请先构建！");
                }

                return _allTables;
            }
        }

        /// <summary>
        /// 主动构建
        /// </summary>
        public static void Build()
        {
            if (_allTables != null)
            {
                return;
            }

            //resource加载路径
            var rescourcePath = "TableTool/allInOne";
            var addressablePath = Config.Address;
            if (string.IsNullOrWhiteSpace(addressablePath))
            {
                //使用Addressable,加载table
                if (Config.LoadMode == LoadMode.Addressable)
                {
                    switch (Config.FileType)
                    {
                        case JsonFileType.Json:
                            addressablePath = "Assets/Typhoon_Gen/TableTool/Export/allInOne.json";
                            break;
                        case JsonFileType.Base64:
                            addressablePath = "Assets/Typhoon_Gen/TableTool/Export/allInOne.bytes";
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            //判断加载方式
            switch (Config.LoadMode)
            {
                case LoadMode.Resource:
                    var json = Resources.Load<TextAsset>(rescourcePath).text;
                    //构建
                    CreateAllTable(json, Config.FileType == JsonFileType.Base64);
                    break;
                case LoadMode.Addressable:
                    throw new Exception("Addressable模式下请调用异步方法：BuildAsync()主动构建");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static async Task BuildAsync()
        {
            if (_allTables != null)
            {
                return;
            }

            var rescourcePath = "TableTool/allInOne";
            var addressablePath = Config.Address;
            if (string.IsNullOrWhiteSpace(addressablePath))
            {
                //使用Addressable,加载table
                if (Config.LoadMode == LoadMode.Addressable)
                {
                    switch (Config.FileType)
                    {
                        case JsonFileType.Json:
                            addressablePath = "Assets/Typhoon_Gen/TableTool/Export/allInOne.json";
                            break;
                        case JsonFileType.Base64:
                            addressablePath = "Assets/Typhoon_Gen/TableTool/Export/allInOne.bytes";
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            //判断加载方式
            switch (Config.LoadMode)
            {
                case LoadMode.Resource:
                {
                    var request = Resources.LoadAsync<TextAsset>(rescourcePath);
                    while (true)
                    {
                        await Task.Yield();
                        if (request.isDone)
                        {
                            var json = (request.asset as TextAsset).text;
                            //构建
                            CreateAllTable(json, Config.FileType == JsonFileType.Base64);
                            break;
                        }
                    }
                }
                    break;
                default:
                    throw new Exception("请重新导表生成对应的TableTool");
            }
        }

        //创建AllTable实例
        public static void CreateAllTable(string json, bool base64)
        {
            if (base64)
            {
                var bytes = Convert.FromBase64String(json);
                var data = Encoding.UTF8.GetString(bytes);
                _allTables = AllTables.Build(data);
            }
            else
            {
                _allTables = AllTables.Build(json);
            }
        }

        /// <summary>
        /// 从AssetDatabase加载
        /// </summary>
        private static void LoadFromAssetDatabase()
        {
#if UNITY_EDITOR
            string path = $"Assets/Typhoon_Gen/TableTool/Export";
            switch (Config.LoadMode)
            {
                case LoadMode.Resource:
                    path += "/Resources/TableTool";
                    break;
            }

            switch (Config.FileType)
            {
                case JsonFileType.Json:
                    path += "/allInOne.json";
                    break;
                case JsonFileType.Base64:
                    path += "/allInOne.bytes";
                    break;
            }

            try
            {
                var json = UnityEditor.AssetDatabase.LoadAssetAtPath<TextAsset>(path).text;
                CreateAllTable(json, Config.FileType == JsonFileType.Base64);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
#endif
        }
    }
}