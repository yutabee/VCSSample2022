namespace Chap12_IndexRange;

class IndexRange
{
    static void Main()
    {
        var dartaary = new int[] { 2020, 7, 24, 9, 0 };

        // 最後から3つめ
        Console.WriteLine(dartaary[^3]); // 出力値：24

        // 2～3番目
        var span = dartaary.AsSpan()[1..3];

        foreach (var d in span)
        {
            Console.Write(d); // 出力値：724
        }
    }
}

