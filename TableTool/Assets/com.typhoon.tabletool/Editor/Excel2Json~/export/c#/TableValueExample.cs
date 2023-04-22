using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 简单用法
    /// </summary>
    [Serializable]
    public class  TableValueExample: ITableValue
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
        /// int数据
        /// </summary>
        public int IntValue;
        /// <summary>
        /// float数据
        /// </summary>
        public float FloatValue;
        /// <summary>
        /// bool数据
        /// </summary>
        public bool BoolValue;
        /// <summary>
        /// string数据
        /// </summary>
        public string StringValue;
        /// <summary>
        /// long数据
        /// </summary>
        public long LongValue;
        /// <summary>
        /// double数据
        /// </summary>
        public double DoubleValue;

    }
}
