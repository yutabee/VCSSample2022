namespace Chap10_RecordInit;

class RecordInit1
{
    // 3つのプロパティを持つレコードの宣言
    record Point
    {
        public String Name { get; init; } = "";
        public float Lat { get; init; } = default;
        public float Lon { get; init; } = default;
    }

    static void Main()
    {
        var p1 = new Point();  // 既定値で初期化される
        Console.WriteLine(p1); // ToString()メソッドが呼ばれる
        // 出力値:Point { Name = , Lat = 0, Lon = 0 }

        // オブジェクト初期化子による初期化
        p1 = new Point
        {
            Name = "大阪城",
            Lat = 34.687f,
            Lon = 135.526f
        };
        Console.WriteLine(p1);
        // 出力値:Point { Name = 大阪城, Lat = 34.687, Lon = 135.526 }
    }
}
