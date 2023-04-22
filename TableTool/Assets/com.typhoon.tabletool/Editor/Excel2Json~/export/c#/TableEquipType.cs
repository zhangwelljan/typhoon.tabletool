using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 装备类型
    /// </summary>
    [Serializable]
    public class  TableEquipType: ITableValue
    {
        /// <summary>
        /// 数字key
        /// </summary>
        public int Id;
        /// <summary>
        /// 中文key
        /// </summary>
        public string Name;
        /// <summary>
        /// 枚举名
        /// </summary>
        public string EnumName;

        public TableItemParam2 Param2;
        [JsonIgnore] public EnumEquipType __Enum
        {
            get
            {
                return (EnumEquipType) Id;
            }
        }

    }
}
