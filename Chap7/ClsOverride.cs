using System;

namespace Chap7_ClsOverride
{
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
        public override void BaseInfo() // 基本クラスのメソッドをオーバーライド
        {
            Console.WriteLine("Song");
        }
    }

    // 派生クラス
    class Music2 : Music
    {
        new public void BaseInfo() // 基本クラスのメソッドを隠蔽
        {
            Console.WriteLine("Music2");
        }
    }

    class ClsOverride
    {
        static void Main()
        {
            var s = new Song();
            s.BaseInfo();              // 出力値："Song"

            var m2 = new Music2();
            m2.BaseInfo();             // 出力値："Music2"

            var m = new Music();
            m.BaseInfo();              // 出力値："Music"
        }
    }
}