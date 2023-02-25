namespace Chap10_NullableConditional;

class NullableConditional2
{
    static void Main()
    {
        var t = new Team();

        string? n = t.Member?.Name;
        Console.WriteLine(n);

        var t2 = new Team();
        // ?.演算子と??演算子の組み合わせ
        string n2 = t2.Member?.Name ?? "nothing";
        Console.WriteLine(n2);  // 出力値：nothing
    }
}

