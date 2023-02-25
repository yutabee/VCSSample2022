namespace Chap6_ClsNameParam;
class TestClass
{
    // 2つのパラメーターを受け取ってint型の値を返すメソッド
    public int CalcAdd(int a, int b)
    {
        return a + b; // パラメーターのaとbを加算して返す
    }
    public int CalcAdd2(int a, int b, int c)
    {
        return a + b + c; // パラメーターのa、b、ｃを加算して返す
    }
}

class ClsNameParam2
{
    static void Main()
    {
        var test = new TestClass();

        // パラメータの混在
        int a = test.CalcAdd2(3, c: 4, b: 2);

        // C# 7.2以降OK
        int b = test.CalcAdd2(a: 3, 4, 1);

        // NG（順序を変更できない）
        //int c = test.CalcAdd2(b: p, a: 3, 1);

        Console.WriteLine(a);               // 出力値：9
        Console.WriteLine(b);               // 出力値：8
    }
}
