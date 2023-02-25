namespace Chap5_IfStmt;

class IfStmt1
{
    static void Main()
    {
        int x = 5;

        if (x < 10)               // xが10より小さいなら
        {
            x *= 10;              // xを10倍する
        }
        Console.WriteLine(x);     // 出力値：50
    }
}

