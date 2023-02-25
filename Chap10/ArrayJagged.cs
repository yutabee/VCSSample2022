namespace Chap10_ArrayJagged;

class ArrayJagged
{
    static void Main()
    {
        // 2次元配列のベースとなる配列を定義
        int[][,] a = new int[3][,];

        // 2次元配列を定義して代入
        a[0] = new int[,] { { 10, 20 }, { 100, 200 } };
        a[1] = new int[,] { { 30, 40, 50 }, { 300, 400, 500 } };
        a[2] = new int[,] { { 60, 70, 80, 90 }, { 600, 700, 800, 900 } };

        // 配列の参照例
        Console.WriteLine(a[0][0, 0]);  // 出力値：10
        Console.WriteLine(a[1][1, 1]);  // 出力値：400
        Console.WriteLine(a[2][1, 3]);  // 出力値：900

        // ベースとなる配列のサイズを表示する
        Console.WriteLine(a.Length);    // 出力値：3

        // 各サブ配列のサイズを表示する
        Console.WriteLine(a[0].Length); // 出力値：4
        Console.WriteLine(a[1].Length); // 出力値：6
        Console.WriteLine(a[2].Length); // 出力値：8

        // 次元数を表示する
        Console.WriteLine(a.Rank);      // 出力値：1
        Console.WriteLine(a[0].Rank);   // 出力値：2
    }
}

