namespace Chap12_StringFormat;

class StringFormat
{
    static void Main()
    {
        string one = "1";
        int n1 = 2;
        int n2 = 3;

        Console.WriteLine(string.Format("{0}プラス{1}は{2}です", one, n1, n2));
        // 出力値：1プラス2は3です

        Console.WriteLine(string.Format("【{0,3}】月【{1,-2}】日", 1, 2));
        // 出力値：【  1】月【2 】

        Console.WriteLine(string.Format("{0:D4}, {1:D5}", 123, 12));
        // 出力値：0123, 00012

        Console.WriteLine(string.Format("{0:C2}", 12345));   // ¥12,345.00
        Console.WriteLine(string.Format("{0:E}", 12345));    // 1.234500E+004
        Console.WriteLine(string.Format("{0:F2}", 12.345));  // 12.35
        Console.WriteLine(string.Format("{0:N2}", 12345));   // 12,345.00
        Console.WriteLine(string.Format("{0:P2}", 0.12345)); // 12.35%
        Console.WriteLine(string.Format("{0:X}", 76476));    // 12ABC

        double n = 1234567.89;
        Console.WriteLine(string.Format("{0:0.#}", n));        // 1234567.9
        Console.WriteLine(string.Format("{0:#.#}", n));        // 1234567.9
        Console.WriteLine(string.Format("{0:#}", n));          // 1234568
        Console.WriteLine(string.Format("{0:#.##}", n));       // 1234567.89
        Console.WriteLine(string.Format("{0:#.###}", n));      // 1234567.89
        Console.WriteLine(string.Format("{0:#.0}", n));        // 1234567.9
        Console.WriteLine(string.Format("{0:#.00}", n));       // 1234567.89
        Console.WriteLine(string.Format("{0:#.000}", n));      // 1234567.890
        Console.WriteLine(string.Format("{0:#,0.000}", n));    // 1,234,567.890
        Console.WriteLine(string.Format("{0:0,0.000}", n));    // 1,234,567.890
        Console.WriteLine(string.Format("{0:00,000,000.000}", n));
        // 01,234,567.890


        var first = "日経";
        var last = "太郎";

        var str1 = String.Format("私の名前は {0} {1} です。", first, last);
        Console.WriteLine(str1); // 出力値：私の名前は 日経 太郎 です。

        // C#バージョン6での書き方
        var str2 = $"私の名前は {first} {last} です。";
        Console.WriteLine(str2); // 出力値：私の名前は 日経 太郎 です。

        var price = 645;
        var str3 = $@"
Price: {price:C}-
Tax: {price * 0.08:C}-
";
        Console.WriteLine(str3);
        // 出力値：
        // Price: \645 -
        // Tax: \52 -

    }
}
