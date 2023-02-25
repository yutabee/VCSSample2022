namespace Chap4_Print3Ope;

class Print3Ope
{
    static void Main()
    {
        int x = -5;

        Console.WriteLine(x >= 0 ? x : -x);      // 出力値：5
        Console.WriteLine(x < 0 ? '負' : '正');  // 出力値：負
    }
}

