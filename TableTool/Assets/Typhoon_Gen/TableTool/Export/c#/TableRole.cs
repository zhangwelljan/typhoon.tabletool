using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 测试
    /// </summary>
    [Serializable]
    public class  TableRole: ITableValue
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id;
        /// <summary>
        /// name
        /// </summary>
        public string Name;

        public TableItemSkins Skins;

    }
}
