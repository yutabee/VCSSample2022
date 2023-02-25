using System;
namespace Chap5_IfStmt;

class IfStmt2
{
    static void Main()
    {
        int x = 15;

        if (x < 10)
        {
            x *= 10;
        }
        else
        {
            x = -x;
        }
        Console.WriteLine(x);  // 出力値：-15
    }
}

