namespace Practice9_1;

class Practice
{
    static void Main()
    {
        int a = 10;

        try
        {
            int b = a / 0;
            Console.WriteLine(b);
        }
        catch
        {
            Console.WriteLine("例外発生");
        }
    }
}

