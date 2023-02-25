namespace Chap6_ClsRefEase;

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

    public int RefCalcAdd(in int a, in int b)
    {
        ref readonly int ra = ref a;
        ref readonly int rb = ref b;

        // NG 値を書き換えられない
        // ra++;

        return ra + rb; // パラメーターのaとbを加算して返す
    }

}

class ClsRefEase
{
    static void Main()
    {
        var test = new TestClass();

        int c = 1;
        int d = 2;

        ref int x = ref c < d ? ref c : ref d;

        x = 5;
        // cの値も書き換わる
        Console.WriteLine(c);               // 出力値：5
    }
}
