namespace Chap11_DelegateParam;

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

class DelegateParam
{
    // デリゲート型変数をパラメータとしたメソッド
    public static void MethodCallback(int p, SampleDel delVar)
    {
        // デリゲートを介したメソッドの呼び出し
        delVar(p);
    }

    public static void Main()
    {
        var t = new TestClass();

        // パラメータとしてメソッドを渡す
        MethodCallback(10, t.TestMethod1);          // 出力値：10
        MethodCallback(10, TestClass.TestMethod2);  // 出力値：20
    }
}
