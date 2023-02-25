namespace Practice5_1;

class Practice
{
    static void Main()
    {
        // forループ
        int a = 0;
        for (int i = 1; i <= 10; i++)
        {
            a += i;
        }
        Console.WriteLine(a);

        // whileループ
        int b = 0;
        int j = 1;
        while (j <= 10)
        {
            b += j;
            j++;
        }
        Console.WriteLine(b);
    }
}

