namespace Chap4_PrintShift;

class PrintShift
{
    static void Main()
    {
        int a = 162; // 16進数表記では、0xA2

        // 2進数文字列に変換
        Console.WriteLine(Convert.ToString(a, 2));      // 出力値：00010100010
        Console.WriteLine(Convert.ToString(a << 3, 2)); // 出力値：10100010000
        Console.WriteLine(Convert.ToString(a >> 3, 2)); // 出力値：00000010100
    }
}

