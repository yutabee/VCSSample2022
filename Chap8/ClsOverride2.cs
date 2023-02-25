using System;
namespace Chap8_ClsOverride;

// 派生クラス
class Music2 : Music
{
    new public void BaseInfo() // メソッドを隠蔽
    {
        Console.WriteLine("Music2");
    }
}

class ClsOverride2
{
    static void Main()
    {
        Music m;            // Musicクラス型の変数

        m = new Music2();   // Music2クラスのインスタンスを代入
        m.BaseInfo();       // 出力値：Music
    }
}
