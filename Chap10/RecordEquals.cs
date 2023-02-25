namespace Chap10_RecordEquals;

class RecordEquals
{
    record Point(String Name, float Lat, float Lon);

    class CPoint
    {
        public String Name { get; init; } = "";
        public float Lat { get; init; } = default;
        public float Lon { get; init; } = default;
    }

    static void Main()
    {
        // クラスの比較
        var c1 = new CPoint();
        var c2 = new CPoint();
        Console.WriteLine(c1 == c2); // 出力値:False
        Console.WriteLine(c1 != c2); // 出力値:True

        // レコードの比較
        var p1 = new Point("", 0f, 0f);
        var p2 = new Point("", 0f, 0f);
        Console.WriteLine(p1 == p2); // 出力値:True
        Console.WriteLine(p1 != p2); // 出力値:False
    }
}
