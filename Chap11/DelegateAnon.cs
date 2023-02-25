namespace Chap11_DelegateAnon;

// SampleDelという名前のデリゲートを定義
delegate void SampleDel(int x);

class DelegateAnon
{
    public static void Main()
    {
        // 匿名メソッドを使ったデリゲート型の変数の定義
        SampleDel delVar = delegate (int n) { Console.WriteLine(n); };
        delVar(123);        // 出力値：123
    }
}
