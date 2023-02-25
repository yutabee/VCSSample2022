using System;
namespace Chap8_ClsOverride;

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
    public override void BaseInfo() // 同じメソッドを定義
    {
        Console.WriteLine("Song");
    }
}

// 派生クラス
class Symphony : Music
{
    public override void BaseInfo() // 同じメソッドを定義
    {
        Console.WriteLine("Symphony");
    }
}

class ClsOverride1
{
    static void Main()
    {
        Music m;            // Musicクラス型の変数

        m = new Song();     // Songクラスのインスタンスを代入
        m.BaseInfo();       // 出力値：song

        m = new Symphony(); // Symphonyクラスのインスタンスを代入
        m.BaseInfo();       // 出力値：Symphony
    }
}

