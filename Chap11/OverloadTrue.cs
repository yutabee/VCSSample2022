namespace Chap11_OverloadTrue;

class TestClass
{
    private readonly int num;
    private readonly string? str;

    public TestClass(int num, string? str)
    {
        this.num = num;
        this.str = str;
    }

    // true演算子の定義
    public static bool operator true(TestClass a)
    {
        return (a.num != 0) && (a.str != null);
    }

    // false演算子の定義
    public static bool operator false(TestClass a)
    {
        return (a.num == 0) && (a.str == null);
    }
}

class OverloadTrue
{
    // true、falseの判定
    public static void BoolTest(TestClass t)
    {
        // true演算子で判断
        if (t)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public static void Main()
    {
        var a = new TestClass(1, "演算子");
        var b = new TestClass(0, null);

        BoolTest(a);    // 出力値：true
        BoolTest(b);    // 出力値：false
    }
}
