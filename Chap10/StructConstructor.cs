namespace Chap10_StructConstructor;
struct Simple
{
    public int Number;
    public string Name;

    // パラメーター付きのコンストラクター
    public Simple(int n, string s)
    {
        Number = n;
        Name = s;
    }

    // C# 10.0では定義できる
    public Simple()
    {
        Number = -1;
        Name = "既定";
    }
}

class StructConstructor
{
    static void Main()
    {
        // 既定のコンストラクターが呼び出される
        var s0 = new Simple();
        Console.WriteLine(s0.Number);   // 出力値：-1
        Console.WriteLine(s0.Name);     // 出力値：既定

        // 既定値で初期化される
        Simple s1 = default;
        Console.WriteLine(s1.Number);   // 出力値：0（int型の既定値）
        Console.WriteLine(s1.Name);     // 何も出力されない（string型の既定値null）

        // 明示的にコンストラクターを呼び出す
        var s2 = new Simple(1, "testname");

        Console.WriteLine(s2.Number);   // 出力値：1
        Console.WriteLine(s2.Name);     // 出力値：testname

        // コンストラクターは呼ばれない
        //Simple ss;

        // メンバが未定義でコンパイルエラー
        //Console.WriteLine(ss.Name);
    }
}
