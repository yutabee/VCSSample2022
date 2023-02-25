namespace Practice3_2;

class Practice
{
    static void Main()
    {
        // 逐語的リテラル文字列
        string s1 = @"\1,000
\20,000";
        Console.WriteLine(s1);

        string s2 = "\\1,000\n\\20,000";
        Console.WriteLine(s2);
    }
}

