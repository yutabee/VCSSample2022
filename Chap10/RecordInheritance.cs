namespace Chap10_RecordInheritance;

class RecordInheritance
{
    record Point(String Name, float Lat, float Lon);

    record NewPoint1(float El) : Point("初期地点", 0f, 0f);
    
    record NewPoint2(String Name, float Lat, float Lon, float El)
        : Point(Name, Lat, Lon);


    static void Main()
    {
        var p1 = new NewPoint1(0f);
        Console.WriteLine(p1);
        // 出力値:NewPoint1 { Name = 初期地点, Lat = 0, Lon = 0, El = 0 }

        var p2 = new NewPoint2("甲子園", 34.721279f, 135.361554f, 1.8f);
        Console.WriteLine(p2.Name);// 出力値:甲子園
    }
}
