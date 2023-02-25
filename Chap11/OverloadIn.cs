namespace Chap11_OverloadIn;

class TestClass
{
    readonly string Str;
    readonly int Num;

    public TestClass(int num, string str)
    {
        this.Num = num;
        this.Str = str;
    }

    public void Output() => Console.WriteLine($"{this.Num} {this.Str}");

    // +演算子のユーザー定義(inパラメータはOK)
    public static TestClass operator +(in TestClass a, in TestClass b) => new (a.Num + b.Num, a.Str + b.Str);
}

class OverloadIn
{
    public static void Main()
    {
        var a = new TestClass(1, "演算子");
        a += new TestClass(2, "オーバーロード");

        a.Output(); // 出力値：3 演算子オーバーロード
    }
}
