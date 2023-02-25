using System;
namespace Chap8_ClsInterMem;

interface IBaseInterface1
{
    void PrintOut(string s);
}

interface IBaseInterface2
{
    void PrintOut(string t);   // INterface1と同じメソッド
}

// インターフェイスの実装
class SampleClass : IBaseInterface1, IBaseInterface2
{
    public void PrintOut(string s)
    {
        Console.WriteLine("Interface0 : " + s);
    }

    // 明示的なインターフェイスの宣言
    void IBaseInterface1.PrintOut(string s)
    {
        Console.WriteLine("Interface1 : " + s);
    }

    // 明示的なインターフェイスの宣言
    void IBaseInterface2.PrintOut(string s)
    {
        Console.WriteLine("Interface2 : " + s);
    }
}

class ClsInterMem
{
    static void Main()
    {
        var sc = new SampleClass();

        sc.PrintOut("0");                   // 出力値："Interface0 : 0"

        IBaseInterface1 ifc1 = (IBaseInterface1)sc;   // インターフェイスに変換
        ifc1.PrintOut("1");                 // 出力値："Interface1 : 1"

        IBaseInterface2 ifc2 = (IBaseInterface2)sc;   // インターフェイスに変換
        ifc2.PrintOut("2");                 // 出力値："Interface2 : 2"
    }
}
