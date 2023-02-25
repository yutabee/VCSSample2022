namespace Chap11_LambdaCapture;

class LambdaCapture
{
    public static void Main()
    {
        // 引数、戻り値がないラムダ式を返すローカル関数
        Action CreateLambda(int n)
        {
            int b = 2;
            return () =>
            {
                Console.WriteLine(n * b);
                // ローカル変数をインクリメントする
                b++;
            };
        }
        Action action = CreateLambda(3);

        // ラムダ式の実行
        action();           // 出力値：6
                            // 次のラムダ式の実行でも変数bは有効
        action();           // 出力値：9
    }
}
