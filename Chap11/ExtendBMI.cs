namespace Chap11_ExtendBMI;

// 拡張メソッドを定義したクラス
static class ExtendTestClass
{
    // 拡張メソッド（肥満度判定）
    public static void CheckJ(this TestClass t)
    {
        // BMIが25以上を肥満、18未満をやせすぎ、それ以外を標準とする。
        if (25 <= t.BMI())
        {
            Console.WriteLine("肥満です");
        }
        else if (t.BMI() < 18)
        {
            Console.WriteLine("やせすぎです");
        }
        else
        {
            Console.WriteLine("標準です");
        }
    }
}

// 体重、身長を保持してBMI値を出力するクラス
class TestClass
{
    // 体重のプロパティ
    public double Weight { get; }

    // 身長のプロパティ
    public double Height { get; set; }


    // 体重、身長を指定して初期化
    public TestClass(double w, double h)
    {
        this.Weight = w;        // キログラム
        this.Height = h / 100;  // センチメートルをメートルに変換して格納
    }

    // BMI値を求める
    public double BMI()
    {
        return this.Weight / (this.Height * this.Height);
    }
}

class ExtendBMI
{
    public static void Main()
    {
        // 身長と体重を指定（キログラム、センチメートル）
        var a = new TestClass(80, 170);

        // 肥満度の判定（拡張メソッド）
        a.CheckJ();    // 出力値：肥満です

        var b = new TestClass(40, 160);
        b.CheckJ();    // 出力値：やせすぎです
    }
}
