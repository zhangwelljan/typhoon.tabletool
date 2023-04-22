using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    [Serializable]
    public class  TableItemAaparam
    {
        /// <summary>
        /// 类型1
        /// </summary>
        public string[] EquipType;
        [JsonIgnore] public TableEquipType[] __EquipType
        {
            get
            {
                return AllTables.GetLink("equipType", "name", EquipType)as TableEquipType[];
            }
        }

    }
}