namespace Practice9_2;

class Practice
{
    static void Main()
    {
        int a = 50;
        int b = 10;
        try
        {
            checked
            {
                byte result = (byte)(a * b);
                Console.WriteLine("{0} x {1} = {2}", a, b, result);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

