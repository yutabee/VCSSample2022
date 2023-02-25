namespace Chap5_ForStmt;

class ForStmt2
{
    static void Main()
    {
        for (int i = 0, j = 0; i + j < 10; i++, j += 2)
        {
            Console.WriteLine("{0},{1}", i, j);
        }
    }
}

