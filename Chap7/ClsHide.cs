namespace Chap7_ClsHide;

    // 基本クラス
    class Music
    {
        public int Type = 0;
        public string Name = "Music";

        public void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // 派生クラス
    class Music2 : Music
    {
        new public int Type = 1;   // 同じフィールドを定義 => 隠ぺい

        new public void BaseInfo() // 同じメソッドを定義
        {
            Console.WriteLine("Music2");
        }
    }

class ClsHide
{
    static void Main()
    {
        var m2 = new Music2();

        m2.BaseInfo();              // 出力値：Music2
        Console.WriteLine(m2.Type); // 出力値：1
    }
}
