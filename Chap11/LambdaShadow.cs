namespace Chap11_LambdaShadow;
class LambdaShadow
{
    public static void Main()
    {
        int b = 2;
        LocalFunctionShadow(3); // 出力値：9

        static void LocalFunctionShadow(int b)
        {
            Console.WriteLine(b * b); // bは、外部のbとは別の変数
        }

    }
}
