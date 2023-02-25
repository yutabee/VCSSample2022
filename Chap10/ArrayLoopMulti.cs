using System;
namespace Chap10_ArrayLoopMulti;

class ArrayLoopMulti
{
    static void Main()
    {
        // 2次元配列
        string[,] a = { { "一", "二" }, { "三", "四" }, { "五", "六" } };

        // 2次元配列を表現して出力する
        for (var i = 0; i < a.GetLength(0); i++)
        {
            // 2次元めの要素数だけ横に表示
            for (var j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine("");
        }
    }
}

