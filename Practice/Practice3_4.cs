namespace Practice3_4;
class Practice34
{
    // 四季を表す列挙型
    enum FourSeasons
    {
        Spring, Summer, Autumn, Winter
    }

    static void Main()
    {
        Console.WriteLine(FourSeasons.Spring);      // 出力値:Spring
        Console.WriteLine((int)FourSeasons.Spring); // 出力値:0

        // 四季を表す文字列型配列
        var s = new[] { "春", "夏", "秋", "冬" };

        Console.WriteLine(s[(int)FourSeasons.Spring]);      // 出力値:春

    }
}

