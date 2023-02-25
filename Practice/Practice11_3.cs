namespace Practice11_3;

class Sample
{
    static void Main()
    {
        static int Test(object? p)
        {
            return p switch
            {
                (int n, _) when n < 10 => n,
                string s => s.Length,
                { } => 0,
                _ => -1
            };
        }
        Console.WriteLine(Test((5, "a")));  // 出力値：5
        Console.WriteLine(Test((10, "b"))); // 出力値：0
        Console.WriteLine(Test("sample"));  // 出力値：6
        Console.WriteLine(Test(null));      // 出力値：-1
    }
}

