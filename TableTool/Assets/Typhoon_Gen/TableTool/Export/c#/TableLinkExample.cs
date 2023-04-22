using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 表间关联
    /// </summary>
    [Serializable]
    public class  TableLinkExample: ITableValue
    {
        /// <summary>
        /// 数字ID
        /// </summary>
        public int Id;
        /// <summary>
        /// 字符串ID
        /// </summary>
        public string Name;
        /// <summary>
        /// 关联到valueExample表（匹配name）
        /// </summary>
        public string ValueExample;
        /// <summary>
        /// 关联到arrayExample表（匹配name）
        /// </summary>
        public string ArrayExample;
        /// <summary>
        /// 关联枚举enumExample表（匹配name）
        /// </summary>
        public string EnumExample;
        [JsonIgnore] public TableValueExample __ValueExample
        {
            get
            {
                return AllTables.GetLink("valueExample", "name", ValueExample) as TableValueExample;
            }
        }
        [JsonIgnore] public TableArrayExample __ArrayExample
        {
            get
            {
                return AllTables.GetLink("arrayExample", "name", ArrayExample) as TableArrayExample;
            }
        }
        [JsonIgnore] public TableEnumExample __EnumExample
        {
            get
            {
                return AllTables.GetLink("enumExample", "name", EnumExample) as TableEnumExample;
            }
        }

    }
}
