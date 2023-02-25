namespace Practice5_2;

class Practice
{
    static void Main()
    {
        for (int i = 1; i <= 50; i++)
        {
            if ((i % 3 == 0) || (i % 10 == 3) || (i / 10 == 3))
            {
                Console.WriteLine(i);
            }
        }
    }
}

