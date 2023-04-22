using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 数组用法
    /// </summary>
    [Serializable]
    public class  TableArrayExample: ITableValue
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
        /// int数组
        /// </summary>
        public int[] IntArray;
        /// <summary>
        /// float数组
        /// </summary>
        public float[] FloatArray;
        /// <summary>
        /// bool数组
        /// </summary>
        public bool[] BoolArray;
        /// <summary>
        /// string数组
        /// </summary>
        public string[] StringArray;
        /// <summary>
        /// long数组
        /// </summary>
        public long[] LongArray;
        /// <summary>
        /// double数组
        /// </summary>
        public double[] DoubleArray;

    }
}
