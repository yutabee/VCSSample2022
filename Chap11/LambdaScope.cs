namespace Chap11_LambdaScope;

class LambdaScope
{
    public static void Main()
    {
        int b = 2;

        // 変数bを参照できる
        Action<int> Multi = n => { Console.WriteLine(n * b); };

        Multi(5);        // 出力値：10

    }
}
