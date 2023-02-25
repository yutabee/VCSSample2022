namespace Chap10_RecordWith;

class RecordWith
{
    record Point(String Name, float Lat, float Lon);

    static void Main()
    {
        var p1 = new Point("初期地点", 0f, 0f);
        // p1.Lat = 0f; エラーとなる
        
        var p2 = p1 with { Name = "どこか" };
        var p3 = p1 with { Lat = 34.687f, Lon = 135.526f };
        var p4 = p1 with { }; // p1の複製となる

        Console.WriteLine(p2);
        // 出力値:Point { Name = どこか, Lat = 0, Lon = 0 }

        Console.WriteLine(p3);
        // 出力値:Point { Name = 初期地点, Lat = 34.687, Lon = 135.526 }

        Console.WriteLine(p4);
        // 出力値:Point { Name = 初期地点, Lat = 0, Lon = 0 }

        Console.WriteLine(p1 == p4); // 出力値:True
    }
}
