namespace Chap6_ClsOutParam;

    class TestClass
    {
        // aの2乗と3乗を求める
        public void TestFunc(int a, out int b, out int c)
        {
            b = a * a;
            c = a * a * a;
        }
    }

class ClsOutParam
{
    static void Main()
    {
        var test = new TestClass();

        int x, y;                   // パラメータ変数の初期化は不要

        // パラメータ変数xとyに3の2乗と3乗が代入される
        test.TestFunc(3, out x, out y);

        //test.TestFunc(3, out int x, out var y);


        Console.WriteLine(x);     // 出力値：9
        Console.WriteLine(y);     // 出力値：27
    }
}

