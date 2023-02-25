namespace Chap10_NullableEnable;
class NullableEnable
{
#nullable enable

    class Simple // NG:警告
    {
        public string Name { get; set; }
    }

    static void Main()
    {
        string s1 = null;    // NG:警告
        string s2 = default; // NG:警告

        string? str1 = null; // OK

        var v = new Simple();
        s1 = "";
        Console.WriteLine(s1);
        Console.WriteLine(s2);
    }
}
