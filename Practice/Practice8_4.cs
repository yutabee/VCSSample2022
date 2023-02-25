namespace Practice8_4;

class Practice
{
    static void Main()
    {
        object val = 23;

        switch (val)
        {
            case int n:
                Console.WriteLine($"値は{n}です");
                break;
            case string s:
                Console.WriteLine(s);
                break;
            default:
                Console.WriteLine("不明");
                break;
        }
    }
}


