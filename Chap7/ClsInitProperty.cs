namespace Chap7_ClsInitProperty;
public class TestClass
{
    public string GetProp { get; }        // getのみ
    public string InitProp { get; init; } // initアクセサー

    public TestClass()
    {
        this.GetProp = "";
        this.InitProp = "";
    }

    public TestClass(string gv, string iv)
    {
        this.GetProp = gv;
        this.InitProp = iv;
    }

    public void TestMethod(string gv, string iv)
    {
        // this.GetProp = gv; // エラーになる
        // this.InitProp = iv; // エラーになる
    }
}

public class ClsInitProperty
    {
    static void Main()
    {
        // コンストラクタはOK
        var t1 = new TestClass("p1", "p2");

        // 以下はエラーになる
        // t1.GetProp = "";
        // t1.InitProp = "";

        // オブジェクト初期化子
        var t2 = new TestClass
        {
            InitProp = "a",
            // GetProp = "b", // エラーになる
        };
    }
}

