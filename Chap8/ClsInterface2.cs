namespace Chap8_ClsInterface;

// プロパティのインターフェイス
interface IPoint
{
    // プロパティ
    int Px
    {
        get; set;
    }

    int Py
    {
        get; set;
    }
}

// プロパティのみのインターフェイスを実装
class ReversePoint : IPoint
{
    // フィールド（private）
    int x;
    int y;

    // コンストラクタ
    public ReversePoint(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // インターフェイスの実装
    public int Px
    {
        get { return -x; }
        set { x = value; }
    }
    public int Py
    {
        get { return -y; }
        set { y = value; }
    }
}

class ClsInterface2
{
    // パラメータがIPointインターフェイスの静的メソッド
    public static void DisplayPoint(IPoint point)
    {
        Console.WriteLine("x={0},y={1}", point.Px, point.Py);
    }

    static void Main()
    {
        var p1 = new ReversePoint(-12, -300);

        // プロパティの参照
        Console.WriteLine(p1.Px);   // 出力値：12
        Console.WriteLine(p1.Py);   // 出力値：300

        var p2 = new ReversePoint(12, 300);

        // プロパティの参照
        DisplayPoint(p2); // 出力値："x=-12, y=-300"

    }
}
