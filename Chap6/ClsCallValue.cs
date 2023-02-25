namespace Chap6_ClsCallValue;

class TestClass
{
    // aを3倍して表示する
    public void TestFunc(int a)
    {
        // パラメーターの変数aを3倍
        a *= 3;

        Console.WriteLine(a);
    }
}

class ClsCallValue
{
    static void Main()
    {
        var test = new TestClass();
        int a = 5;

        test.TestFunc(a);     // 出力値：15
        Console.WriteLine(a); // 出力値：5
    }
}
