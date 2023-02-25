namespace Chap6_ClsRefParam;

class TestClass
{
    // aを３倍する
    public ref int TestFunc(ref int a)
    {
        a *= 3;
        return ref a; // 参照で返す
    }
}

class ClsRefParam
{
    static void Main()
    {
        var test = new TestClass();

        int a = 5;

        ref int b = ref test.TestFunc(ref a); // 戻り値は、変数aの参照
        Console.WriteLine(a);  // 出力値：15
        Console.WriteLine(b);  // 出力値：15

        b = 10;
        Console.WriteLine(a);  // 出力値：10
        Console.WriteLine(b);  // 出力値：10
    }
}
