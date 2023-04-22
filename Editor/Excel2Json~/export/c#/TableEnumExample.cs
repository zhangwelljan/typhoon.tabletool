using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 枚举用法
    /// </summary>
    [Serializable]
    public class  TableEnumExample: ITableValue
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
        /// 枚举名
        /// </summary>
        public string EnumName;
        [JsonIgnore] public EnumEnumExample __Enum
        {
            get
            {
                return (EnumEnumExample) Id;
            }
        }

    }
}
