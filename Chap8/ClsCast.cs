namespace Chap8_ClsCast;

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

class ClsCast
{
    static void Main()
    {
        // SongクラスのインスタンスをMusicクラス型の変数に代入
        var m = new Song();

        // Musicクラス型の変数をキャストしてSongクラス型の変数に代入
        var s = (Song)m;

        // Musicクラス型の変数をキャストしてMusic2クラス型の変数に代入
        // 元がSong型なのでエラーとなる
        // var m2 = (Music2)m;
    }
}
