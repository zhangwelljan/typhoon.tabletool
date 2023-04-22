using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 皮肤
    /// </summary>
    [Serializable]
    public class  TableSkin: ITableValue
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id;
        /// <summary>
        /// name
        /// </summary>
        public string Name;
        /// <summary>
        /// 头发
        /// </summary>
        public string Hair;
        /// <summary>
        /// 身体
        /// </summary>
        public string Body;
        /// <summary>
        /// 材质
        /// </summary>
        public string Mat;

    }
}
