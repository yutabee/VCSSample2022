namespace Chap10_RecordInit;

class RecordInit2
{
    // プライマリコンストラクターで宣言
    public record Point(float Lat, float Lon);

    static void Main()
    {
        var p1 = new Point(34.687f, 135.526f);
        Console.WriteLine(p1.Lat); // 出力値:34.687
    }
}
