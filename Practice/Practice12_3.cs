namespace Practice12_3;

class Practice
{
    static void Main()
    {
        var numbers = new int[] { 5, 8, 2, 9, 4, 6 };

        // 偶数だけを取得する
        var evenQuery = numbers.Where(num => (num % 2) == 0);

        // 表示
        foreach (int n in evenQuery)
        {
            Console.WriteLine(n);
        }
    }
}

