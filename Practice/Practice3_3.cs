namespace Practice3_3;

class Seasons
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
    }
}

