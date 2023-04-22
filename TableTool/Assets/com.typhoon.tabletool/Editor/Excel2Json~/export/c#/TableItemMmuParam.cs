using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace Typhoon.Excel2Json.Export
{
    [Serializable]
    public class  TableItemMmuParam
    {

        public TableItemAaparam Aaparam;
        /// <summary>
        /// 幸运值
        /// </summary>
        public int Lucky;

    }
}