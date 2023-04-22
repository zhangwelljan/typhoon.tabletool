using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    [Serializable]
    public class  TableItemSkins
    {
        /// <summary>
        /// 皮肤1
        /// </summary>
        public string[] Skin;
        [JsonIgnore] public TableSkin[] __Skin
        {
            get
            {
                return AllTables.GetLink<TableSkin>("skin", "name", Skin);
            }
        }

    }
}