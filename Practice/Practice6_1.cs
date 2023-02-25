namespace Practice6_1;

class Practice
{
    static void Main()
    {
        // 指定した数の階乗を求める
        int Sample(int p)
        {
            int fact = 1;
            for (int i = 1; i <= p; i++)
            {
                fact *= i;
            }
            return fact;
        }

        Console.WriteLine(Sample(5));
    }
}

