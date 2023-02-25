namespace Chap11_DelegateInit;

// SampleDelという名前のデリゲートを定義
delegate void SampleDel(int x);

class DelegateInit
{
    // 実際に呼ばれるメソッド
    static void TestMethod(int n)
    {
        Console.WriteLine(n);
    }

    public static void Main()
    {
        // SampleDel型の変数を宣言
        SampleDel delVar;

        // デリゲート型の変数のインスタンス化（メソッド本体を登録）
        delVar = new SampleDel(TestMethod);

        // デリゲートを介してメソッドが呼び出される
        delVar(123);        // 出力値：123
    }
}
