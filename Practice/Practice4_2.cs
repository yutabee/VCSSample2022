namespace Practice4_2;

class Practice
{
    static void Main()
    {
        int x = 10;
        Console.WriteLine(((x % 2) == 0) ? "even" : "odd");
        Console.WriteLine(((x & 1) == 0) ? "even" : "odd");
    }
}

