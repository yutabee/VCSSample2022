namespace Chap6_ClsOptional;

class TestClass
{
    // 省略可能なパラメーターを持つメソッド
    public void PrintName(int no, string name = "nanashi")
    {
        Console.WriteLine(no + "→" + name);
    }
}

class ClsOptional
{
    static void Main()
    {
        var test = new TestClass();

        test.PrintName(10); // test.SampleMethod( 10, "nanashi" );と同じ意味
                            // 出力値：10→nanashi
    }
}
