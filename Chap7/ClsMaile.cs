namespace Chap7_ClsMaile;

// メートルをマイルに変換するクラス
class GetMile
{
    public double this[double m]
    {
        get
        {
            // インデックスのmをデータとして使っている
            return m * 1609.344;
        }
    }
}

class ClsMaile
{
    static void Main()
    {
        var gm = new GetMile();

        Console.WriteLine(gm[2]); // 出力値：3218.688
        Console.WriteLine(gm[3]); // 出力値：4828.032
    }
}
