using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 所有表格
    /// </summary>
    [Serializable]
    public class AllTables
    {
        /// <summary>
        /// 简单用法
        /// </summary>
        public TableListValueExample valueExample;
        /// <summary>
        /// 数组用法
        /// </summary>
        public TableListArrayExample arrayExample;
        /// <summary>
        /// 枚举用法
        /// </summary>
        public TableListEnumExample enumExample;
        /// <summary>
        /// 表间关联
        /// </summary>
        public TableListLinkExample linkExample;
        /// <summary>
        /// 自定义对象
        /// </summary>
        public TableListObjectExample objectExample;


        //忽略
        [JsonIgnore] public Dictionary<string, ITable> Database = new Dictionary<string, ITable>();



        #region 静态方法

        //实例
        private static AllTables _instance = null;

        /// <summary>
        /// json构建AllTables
        /// </summary>
        public static AllTables Build(string json)
        {
            var all = JsonConvert.DeserializeObject<AllTables>(json);
            all.Initialize();
            return all;
        }


        /// <summary>
        /// 获取link项
        /// </summary>
        public static ITableValue GetLink(string table, string column, string key)
        {
            if (_instance == null)
            {
                throw new Exception("未构建AllTable实例");
            }

            return _instance.GetLinkTableValue(table, column, key);
        }

        /// <summary>
        /// 获取link项
        /// </summary>
        public static ITableValue GetLink(string table, string column, int key)
        {
            if (_instance == null)
            {
                throw new Exception("未构建AllTable实例");
            }

            return _instance.GetLinkTableValue(table, column, key);
        }

        /// <summary>
        /// 获取link项
        /// </summary>
        public static ITableValue[] GetLink(string table, string column, string[] keys)
        {
            if (_instance == null)
            {
                throw new Exception("未构建AllTable实例");
            }

            return _instance.GetLinkTableValue(table, column, keys);
        }

        /// <summary>
        /// 获取link项
        /// </summary>
        public static ITableValue[] GetLink(string table, string column, int[] keys)
        {
            if (_instance == null)
            {
                throw new Exception("未构建AllTable实例");
            }

            return _instance.GetLinkTableValue(table, column, keys);
        }

        #endregion

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initialize()
        {
            _instance = this;
            Database["valueExample"] = valueExample;
            Database["arrayExample"] = arrayExample;
            Database["enumExample"] = enumExample;
            Database["linkExample"] = linkExample;
            Database["objectExample"] = objectExample;

        }


        #region 泛用方法

        /// <summary>
        /// 获取表
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public ITable GetTable(string table)
        {
            return Database[table];
        }

        /// <summary>
        /// 是否有表格
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public bool HasTable(string table)
        {
            return Database.ContainsKey(table);
        }

        /// <summary>
        /// 是否有表格条目
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        public bool HasTableValue(string table, string column, string key)
        {
            if (!HasTable(table))
            {
                return false;
            }

            return GetTable(table).Has(column, key);
        }

        /// <summary>
        /// 获取表条目，只有#key标签才支持查询
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="column">列名</param>
        /// <param name="key">匹配名</param>
        /// <returns></returns>
        public ITableValue GetTableValue(string table, string column, string key)
        {
            return Database[table].Get(column, key);
        }

        /// <summary>
        /// 获取表条目，只有#key标签才支持查询
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="column">列名</param>
        /// <param name="key">匹配名</param>
        /// <returns></returns>
        public ITableValue GetTableValue(string table, string column, int key)
        {
            return Database[table].Get(column, key);
        }

        /// <summary>
        /// 获取link表条目
        /// </summary>
        public ITableValue[] GetLinkTableValue(string table, string column, string[] keys)
        {
            var result = new ITableValue[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                var key = keys[i];
                if (string.IsNullOrWhiteSpace(key))
                {
                    result[i] = null;
                    continue;
                }

                result[i] = Database[table].Get(column, key);
            }

            return result;
        }

        /// <summary>
        /// 获取link表条目
        /// </summary>
        public ITableValue[] GetLinkTableValue(string table, string column, int[] keys)
        {
            var result = new ITableValue[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                var key = keys[i];
                result[i] = Database[table].Get(column, key);
            }

            return result;
        }

        /// <summary>
        /// 获取link表条目
        /// </summary>
        public ITableValue GetLinkTableValue(string table, string column, string key)
        {
            return string.IsNullOrWhiteSpace(key) ? null : Database[table].Get(column, key);
        }

        /// <summary>
        /// 获取link表条目
        /// </summary>
        public ITableValue GetLinkTableValue(string table, string column, int key)
        {
            return Database[table].Get(column, key);
        }


        #endregion

        #region 快捷查询API

        public TableValueExample FindTableValueExampleById(int id)
        {
            return valueExample["id", id];
        }

        public TableValueExample FindTableValueExampleByName(string name)
        {
            return valueExample["name", name];
        }

        public TableArrayExample FindTableArrayExampleById(int id)
        {
            return arrayExample["id", id];
        }

        public TableArrayExample FindTableArrayExampleByName(string name)
        {
            return arrayExample["name", name];
        }

        public TableEnumExample FindTableEnumExampleById(int id)
        {
            return enumExample["id", id];
        }

        public TableEnumExample FindTableEnumExampleByName(string name)
        {
            return enumExample["name", name];
        }

        public TableLinkExample FindTableLinkExampleById(int id)
        {
            return linkExample["id", id];
        }

        public TableLinkExample FindTableLinkExampleByName(string name)
        {
            return linkExample["name", name];
        }

        public TableObjectExample FindTableObjectExampleById(int id)
        {
            return objectExample["id", id];
        }

        public TableObjectExample FindTableObjectExampleByName(string name)
        {
            return objectExample["name", name];
        }



        #endregion
    }
}