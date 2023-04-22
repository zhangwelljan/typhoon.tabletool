using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    [Serializable]
    public class  TableListLinkExample: Table<TableLinkExample>
    {
        /// <summary>
        /// 条目索引器
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        public TableLinkExample this[string column, string key]
        {
            get
            {
                return GetValue(column, key);
            }
        }

        /// <summary>
        /// 条目索引器
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        public TableLinkExample this[string column, int key]
        {
            get
            {
                return GetValue(column, key);
            }
        }

    }
}