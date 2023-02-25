namespace Chap10_ArrayMulti;

class ArrayMulti
{
    static void Main()
    {
        // 2次元配列
        int[,] a = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        // 3次元配列
        int[,,] b = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

        // 2次元配列の参照例
        Console.WriteLine(a[0, 0]); // 出力値：1
        Console.WriteLine(a[0, 1]); // 出力値：2
        Console.WriteLine(a[1, 0]); // 出力値：3
        Console.WriteLine(a[1, 1]); // 出力値：4
        Console.WriteLine(a[2, 0]); // 出力値：5
        Console.WriteLine(a[2, 1]); // 出力値：6

        // 3次元配列の参照例
        Console.WriteLine(b[0, 0, 0]); // 出力値：1
        Console.WriteLine(b[0, 0, 1]); // 出力値：2
        Console.WriteLine(b[0, 0, 2]); // 出力値：3
        Console.WriteLine(b[0, 1, 0]); // 出力値：4
        Console.WriteLine(b[0, 1, 1]); // 出力値：5
        Console.WriteLine(b[0, 1, 2]); // 出力値：6
        Console.WriteLine(b[1, 0, 0]); // 出力値：7
        Console.WriteLine(b[1, 0, 1]); // 出力値：8
        Console.WriteLine(b[1, 0, 2]); // 出力値：9
        Console.WriteLine(b[1, 1, 0]); // 出力値：10
        Console.WriteLine(b[1, 1, 1]); // 出力値：11
        Console.WriteLine(b[1, 1, 2]); // 出力値：12
    }
}
