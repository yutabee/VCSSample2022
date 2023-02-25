namespace Chap10_NullableCoalescing;

#nullable disable
class NullableCoalescing
{
    static void Main()
    {
        int? a = null;
        Console.WriteLine(a ?? 10); // 出力値：10

        a = 5;
        Console.WriteLine(a ?? 10); // 出力値：5

        // 参照型でも使える
        string s = null;
        Console.WriteLine(s ?? "Empty"); // 出力値：Empty

        // sがnullなら、右辺が代入される。
        s ??= "空の文字列";
        Console.WriteLine(s);// 出力値：空の文字列
    }
}

