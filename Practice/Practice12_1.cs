namespace Practice12_1;

class Practice
{
    static void Main()
    {
        var list = new List<int>();

        // 1から10を格納する
        for (int i = 1; i <= 10; i++)
        {
            list.Add(i);
        }

        int sum = 0;
        // 1から10を合計する
        foreach (int i in list)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}

