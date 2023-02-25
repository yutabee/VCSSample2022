namespace Chap4_PrintBit;

class PrintBit
{
    static void Main()
    {
        int a = 0b0000_0010;  // 10進数では2
        int b = 0b0000_1111;  // 10進数では15

        Console.WriteLine(Convert.ToString(a & b, 2));
        Console.WriteLine(Convert.ToString(a | b, 2));
        Console.WriteLine(Convert.ToString(a ^ b, 2));
        Console.WriteLine(Convert.ToString(~a, 2));
    }
}

