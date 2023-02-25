namespace Chap6_ClsNameParam;
class ClsNameParam1
{
    static void Main()
    {
        var test = new TestClass();

        int p = 4;

        // どちらも同じ呼び出しになる
        int a = test.CalcAdd(a: 3, b: p);   // メソッドの呼び出し
        int b = test.CalcAdd(b: p, a: 3);   // メソッドの呼び出し

        Console.WriteLine(a);               // 出力値：7
        Console.WriteLine(b);               // 出力値：7
    }
}
