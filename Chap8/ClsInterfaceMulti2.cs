namespace Chap8_ClsInterfaceMulti;

// インターフェイス1

class ClsInterfaceMulti2 : IBaseInterface1, IBaseInterface2
{
    public void Method1(int a)
    {
        Console.WriteLine(a);
    }

    public void Method2(string s)
    {
        Console.WriteLine(s);
    }
}
