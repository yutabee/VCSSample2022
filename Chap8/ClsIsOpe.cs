namespace Chap8_ClsIsOpe;

// 基本クラス
class Music
{
    public virtual void BaseInfo()
    {
        Console.WriteLine("Music");
    }
}

// 派生クラス
class Song : Music
{
    public override void BaseInfo() // メソッドをオーバーライド
    {
        Console.WriteLine("Song");
    }
}

// 派生クラス
class Music2 : Music
{
    new public void BaseInfo() // メソッドを隠蔽
    {
        Console.WriteLine("Music2");
    }
}

class ClsIsOpe
{
    static void Main()
    {
        var m = new Song();

        Song s = m as Song;
        if (s != null)
        {
            s.BaseInfo();  // 出力値：Song
        }
        // ダウンキャストできる場合はs2が定義される
        if (m is Song s2)
        {
            s2.BaseInfo();  // 出力値：Song
        }
    }
}

