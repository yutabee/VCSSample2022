namespace Practice8_3;

class Practice
{
    static void Main()
    {
        object val = 1;

        if (val is int n)
        {
            Console.WriteLine($"値は{n}です");
        }
    }
}


