namespace Chap5_Scope;

class Scope2
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(i);
        }
    }
}

