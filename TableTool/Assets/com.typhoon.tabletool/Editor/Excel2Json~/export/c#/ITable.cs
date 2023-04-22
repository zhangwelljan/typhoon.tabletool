namespace Typhoon.Excel2Json.Export
{
    /// <summary>
    /// 表格接口
    /// </summary>
    public interface ITable
    {
        /// <summary>
        /// 是否有条目
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        bool Has(string column, string key);

        /// <summary>
        /// 查找条目
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        ITableValue Get(string column, string key);

        /// <summary>
        /// 查找table
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        ITableValue Get(string column, int key);
    }

    /// <summary>
    /// 表格接口
    /// </summary>
    public interface ITable<T> : ITable where T : ITableValue
    {
        /// <summary>
        /// 查找条目
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        T GetValue(string column, string key);

        /// <summary>
        /// 查找table
        /// </summary>
        /// <param name="column">列名</param>
        /// <param name="key">key</param>
        /// <returns></returns>
        T GetValue(string column, int key);
    }
}