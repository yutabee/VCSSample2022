namespace Chap8_ClsAbstract;

// 抽象クラス（基本クラス）
abstract class Music
{
    public abstract void GetInfo();     // 抽象メソッド
}

// 派生クラス
class Song : Music
{
    public override void GetInfo()      // overrideをつける
    {
        Console.WriteLine("Song");
    }
}

class ClsAbstract
{
    static void Main()
    {
        var s = new Song();
        s.GetInfo();                   // 出力値：Song
    }
}
