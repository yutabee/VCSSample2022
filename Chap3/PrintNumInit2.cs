namespace Chap3_PrintNum;

class PrintNumInit2
{
    static void Main()
    {
        int a = 10, b = 20;

        Console.WriteLine(a); // 出力値：10
        Console.WriteLine(b); // 出力値：20

        int c, d;

        c = a; // 同じデータ型の変数で初期化することもできる
        d = b;

        Console.WriteLine(c); // 出力値：10
        Console.WriteLine(d); // 出力値：20
    }
}

