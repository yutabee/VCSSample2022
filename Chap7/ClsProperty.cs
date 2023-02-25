namespace Chap7_ClsProperty;

// 基本クラス
class Music
{
    int type = 0;                       // 既定はprivate
    protected string name = "Music";

    public int Type
    {
        set
        {
            this.type = value;
        }
        get
        {
            return this.type;
        }
    }
}

class ClsProperty
{
    static void Main()
    {
        var m = new Music();
        m.Type = 1;                   // setが呼ばれる
        Console.WriteLine(m.Type);    // getが呼ばれる
    }
}