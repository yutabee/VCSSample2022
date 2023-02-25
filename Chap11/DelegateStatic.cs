namespace Chap11_DelegateStatic;

// SampleDelという名前のデリゲートを定義
delegate void SampleDel(int x);



class TestClass
{
    public void TestMethod1(int n)
    {
        Console.WriteLine(n);
    }

    // 静的メソッド
    public static void TestMethod2(int n)
    {
        Console.WriteLine(n * 2);
    }
}

class DelegateStatic
{
    public static void Main()
    {
        // TestClassのインスタンス化
        var t = new TestClass();

        // インスタンスメソッドの登録
        SampleDel delVar = t.TestMethod1;

        delVar(123);        // 出力値：123

        // 静的メソッドの登録（同じ変数に代入できる）
        delVar = TestClass.TestMethod2;

        delVar(123);        // 出力値：246


    }
}
