namespace Chap11_ExtendRef;

// 構造体（緯度経度）
public struct Point
{
    public double lat, lon;

    public Point(double y, double x)
    {
        lon = x;
        lat = y;
    }
}

public static class GetMeshCode
{
    // １次メッシュコードを求める（int型にキャストすることで小数点以下を切り捨てる）
    public static int Mesh1(in this Point p) => (int)(p.lat * 1.5) * 100 + (int)(p.lon - 100);
}

class ExtendRef
{
    public static void Main()
    {
        var p = new Point(34.687426, 135.525845);

        Console.WriteLine(p.Mesh1()); // 出力値：5235
    }
}
