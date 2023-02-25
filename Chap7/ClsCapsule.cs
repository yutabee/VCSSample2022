namespace Chap7_ClsCapsule;

// 基本クラス
class Music
{
    int type = 0;                       // 既定はprivateになる
    protected string name = "Music";

    // typeフィールドに値を設定するpublicメソッド
    public void SetType(int type)
    {
        this.type = type;
    }

    // フィールドの値を出力する仮想メソッド
    public virtual void PrintName()
    {
        Console.WriteLine(type);
        Console.WriteLine(name);
    }
}

// 派生クラス
class Song : Music
{
    public override void PrintName()
    {
        // this.type = 1;
        this.name = "Song";         // nameフィールドに”song”を代入
        base.PrintName();           // 基本クラスのメソッドを呼び出す
    }
}

class ClsCapsule
{
    static void Main()
    {
        Song s = new Song();        // 派生クラスのインスタンスを作成
        s.SetType(1);               // typeフィールドに1を設定
        // s.name = "test";
        s.PrintName();              // 出力値：1　Song
    }
}
