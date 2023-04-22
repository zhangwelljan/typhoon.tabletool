using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 自定义对象
    /// </summary>
    [Serializable]
    public class  TableObjectExample: ITableValue
    {
        /// <summary>
        /// 数字ID
        /// </summary>
        public int Id;
        /// <summary>
        /// 字符串ID
        /// </summary>
        public string Name;

        public TableItemVector3 Vector3;

        public TableItemVector3Array Vector3Array;

    }
}
