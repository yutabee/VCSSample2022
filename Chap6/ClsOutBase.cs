namespace Chap6_ClsOutBase;

class BaseClass
{
    public BaseClass(out string s)
    {
        s = "base";
    }
}

class DerivedClass : BaseClass
{

    public DerivedClass(string s1) : base(out var s2)
    {
        // 初期化子で定義したs1は、コンストラクター内だけで有効
        Console.WriteLine(s1 + s2);
    }
}

class ClsOutBase
{
    static void Main()
    {
        var c = new DerivedClass("test");   // 出力値：testbase
    }
}
