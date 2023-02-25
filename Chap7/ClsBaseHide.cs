namespace Chap7_ClsBaseHide;
// 基本クラス
class BaseClass
{
    public int Type = 0;
}

class NewClass : BaseClass
{
    new public int Type = 1;   // 同じフィールドを定義

    // typeフィールドの値の表示
    public void Print()
    {
        Console.WriteLine(this.Type); // 自身のメンバにアクセス
        Console.WriteLine(base.Type); // 基本クラスのメンバにアクセス
    }
}

class ClsBaseHide
{
    static void Main()
    {
        var n = new NewClass();

        n.Print(); // 派生クラスと基本クラスのtypeフィールドの値を表示
    }
}
