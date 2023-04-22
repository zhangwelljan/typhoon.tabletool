using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 装备
    /// </summary>
    [Serializable]
    public class  TableEquip: ITableValue
    {
        /// <summary>
        /// 数字key
        /// </summary>
        public int Id;
        /// <summary>
        /// 名称key
        /// </summary>
        public string Name;
        /// <summary>
        /// 装备类型
        /// </summary>
        public string EquipType;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int Atk;
        /// <summary>
        /// 血量
        /// </summary>
        public float Hp;
        /// <summary>
        /// 是否绑定
        /// </summary>
        public bool Bind;
        /// <summary>
        /// int数组
        /// </summary>
        public int[] IntArr;
        /// <summary>
        /// float数组
        /// </summary>
        public float[] FloatArr;
        /// <summary>
        /// bool数组
        /// </summary>
        public bool[] BoolArr;
        /// <summary>
        /// string数组
        /// </summary>
        public string[] StringArr;

        public TableItemUpgradeInfo UpgradeInfo;

        public TableItemParam[] Param;

        public TableItemMulParam MulParam;

        public TableItemMmuParam MmuParam;
        [JsonIgnore] public TableEquipType __EquipType
        {
            get
            {
                return AllTables.GetLink("equipType", "name", EquipType) as TableEquipType;
            }
        }

    }
}
