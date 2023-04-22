using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 装备拓展
    /// </summary>
    [Serializable]
    public class  TableEquipExtand: ITableValue
    {
        /// <summary>
        /// 数字key
        /// </summary>
        public int Id;

        public TableItemUpgradeInfo2 UpInfo;

        public TableItemParam Param;

    }
}
