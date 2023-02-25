namespace Chap11_PatternSample;

// 数値と文字列のプロパティを持つクラス
public class Member
{
    public int No { get; }
    public string? Name { get; }

    public Member(int n, string? s)
    {
        this.No = n;
        this.Name = s;
    }

    // 分解（プロパティを取り出す）のメソッド
    public void Deconstruct(out int No, out string? Name)
    {
        No = this.No;
        Name = this.Name;
    }
}

class PatternSample
{
    public static void Main()
    {
        var m = new Member(2, "shota");

        var (no1, name1) = m;                 // 分解
        Console.WriteLine($"{no1},{name1}");  // 出力値：2,shota

        if (m is Member(2, var name))         // is演算子でのvarパターン
        {
            Console.WriteLine(name);          // 出力値：shota
        }

        Console.WriteLine(select(m));                       // 出力値：2
        Console.WriteLine(select(new Member(1, "keita")));  // 出力値：0
        Console.WriteLine(select(new Member(6, "kazuki"))); // 出力値：6
        Console.WriteLine(select(new Member(-1, null)));    // 出力値：-2
        Console.WriteLine(select(null));                    // 出力値：-1
        Console.WriteLine(select2(1, "keita"));             // 出力値：0
        Console.WriteLine(select3(1, "keita"));             // 出力値：0


        // switch式でのpattern
        int select(Member? m)
        {
            return m switch
            {
                (1, "keita") => 0,                  // 位置指定パターン
                { No: 6, Name: "kazuki" } => m.No,  // プロパティパターン
                (var x, _) when x > 0 => x,
                { } => -2,                          // プロパティパターン
                                                    // (null以外すべてに合致する)
                _ => -1
            };
        }

        int select2(int n, string m)
        {
            return (n, m) switch
            {
                (1, "keita") => 0,              // タプルパターン
                { } => -1
            };
        }

        // switchステートメントの複数の値の例
        int select3(int n, string m)
        {
            switch (n, m)
            {
                case (1, "keita"): return 0;
                default: return -1;
            }
        }
    }
}

