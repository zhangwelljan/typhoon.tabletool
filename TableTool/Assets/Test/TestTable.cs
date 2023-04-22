using Sirenix.OdinInspector;
using Typhoon.Excel2Json.Export;
using UnityEngine;

public class TestTable : MonoBehaviour
{
//    public TableEquip Equip;
//    public TableEquip Equip2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    [Button("Method")]
    private void Method()
    {
//        Equip = TableTool.AllTables.FindTableEquipById(1);
//        Equip2 = TableTool.AllTables.FindTableEquipById(3);
    }

    [Button("主动构建")]
    private async void Method2()
    {
        //同步初始化，仅只是Resource模式
        TableHelper.Build();
        //异步初始化
        await TableHelper.BuildAsync();
//        await TableTool.BuildAsync();
        Debug.Log("构建tabletool完毕！");
        // TableHelper.AllTables.GetTable("表名").Get("列名", "字符串ID");
        // TableHelper.AllTables.GetTable("表名").Get("列名", 数字ID);
        TableHelper.AllTables.FindTableValueExampleById(1);
        TableHelper.AllTables.FindTableValueExampleByName("数据1");
        // TableHelper.AllTables.valueExample.Has()
        var tableList = TableHelper.AllTables.valueExample.Data;
        foreach (var element in tableList)
        {
            Debug.Log(element.Name);
        }
    }


    [Button]
    private void Load() {
        var table=TableHelper.AllTables.FindTableValueExampleById(1);
        
        Debug.Log(table.IntValue);
    }
}