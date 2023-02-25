namespace Chap6_ClsStaticClass;

static class TestClass
{
    // 静的メンバー
    public static int a;

    // 静的コンストラクター
    static TestClass()
    {
        a = 5;
    }

    // 静的メソッド
    public static void Display()
    {
        Console.WriteLine(a); // 静的メソッドの呼び出し
    }
}

class ClsStaticClass
{
    static void Main()
    {
        TestClass.Display(); // 出力値：5
    }
}
