namespace Practice10_2;

class Practice
{
    static void Main()
    {
        // 文字列の長さを求める
        int GetLength(string? str)
        {
            return str?.Length ?? 0;
        }

        // 実行例
        string s1 = "123";
        Console.WriteLine(GetLength(s1)); // 出力値：3

        string? s2 = null;
        Console.WriteLine(GetLength(s2)); // 出力値：0
    }

}

