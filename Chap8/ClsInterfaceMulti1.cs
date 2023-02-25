namespace Chap8_ClsInterfaceMulti;

// 基本インターフェイス1
interface IBaseInterface1
{
    void Method1(int a);
}

// 基本インターフェイス2
interface IBaseInterface2
{
    void Method2(string s);
}

// 派生インターフェイス
interface ISampleInterface : IBaseInterface1, IBaseInterface2
{
    void Method3();
}

// 派生インターフェースの実装
class Sample : ISampleInterface
{
    public void Method1(int a)
    {
        Console.WriteLine(a);
    }

    public void Method2(string s)
    {
        Console.WriteLine(s);
    }

    public void Method3()
    {
        Console.WriteLine("method3");
    }
}

class ClsInterfaceMulti1
{
    static void Main()
    {
        var s = new Sample();
        s.Method1(123);             // 出力値：123
        s.Method2("test");          // 出力値：test
        s.Method3();                // 出力値：method3
    }
}
