using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    [Serializable]
    public class  TableItemUpgradeInfo
    {
        /// <summary>
        /// 升级加成1
        /// </summary>
        public int[] UpValue;
        [JsonIgnore] public TableEquipType[] __UpValue
        {
            get
            {
                return AllTables.GetLink("equipType", "id", UpValue)as TableEquipType[];
            }
        }

    }
}