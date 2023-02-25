namespace Chap11_OverloadUser;

class TestClass
{
    private readonly int num;
    private readonly string str;

    public TestClass(int num, string str)
    {
        this.num = num;
        this.str = str;
    }

    public void Output()
    {
        Console.WriteLine(this.num);
        Console.WriteLine(this.str);
    }

    // 明示的な変換
    public static explicit operator TestClass(int num)
    {
        return new TestClass(num, "明示的");
    }

    // 暗黙的な変換
    public static implicit operator TestClass(string str)
    {
        return new TestClass(0, str);
    }
}

class OverloadUser
{
    public static void Main()
    {
        // 明示的な変換
        var a = (TestClass)3;
        a.Output();

        // 暗黙的な変換
        TestClass b = "暗黙的";
        b.Output();
    }
}
