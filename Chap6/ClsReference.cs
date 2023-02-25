namespace Chap6_ClsReference;

class TestClass
{
    // aを３倍して表示する
    public void TestFunc(ref int a)
    {
        a *= 3; // パラメーターの変数aを3倍

        Console.WriteLine(a);
    }
}

class ClsReference
{
    static void Main()
    {
        var test = new TestClass();
        int a = 5;               // 初期化が必要

        test.TestFunc(ref a);  // 出力値：15
        Console.WriteLine(a);  // 出力値：15
    }
}
