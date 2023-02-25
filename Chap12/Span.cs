namespace Chap12_Span;

class Span
{
    static void Main()
    {
        // int型の配列
        var dartaary = new int[] { 2020, 7, 24, 9, 0 };

        // dataaryの2つめから2要素分の参照
        var span = new Span<int>(dartaary, 1, 2);

        foreach (var d in span)
        {
            Console.Write(d); // 出力値：724
        }

        span[0] = 5;

        foreach (var d in dartaary)
        {
            Console.Write(d); // 出力値：202052490
                              // 元の配列の値が書き換わっている
        }

        // 文字列から作成（3つめから1文字）
        var span2 = "Microsoft".AsSpan().Slice(2, 1);
        Console.Write(span2[0]); // 出力値：c

        // span2は、ReadOnlySpanなので書き換えできない
        // span2[0] = "a";
    }
}

