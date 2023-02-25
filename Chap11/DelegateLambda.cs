namespace Chap11_DelegateLambda;
class DelegateLambda
{
    public static void Main()
    {
        // ラムダ式を使ったデリゲート型の変数の定義
        // Action<int>は、戻り値のないパラメーター1つの汎用デリゲート
        Action<int> delVar = n => { Console.WriteLine(n); };

        delVar(123);        // 出力値：123
    }
}
