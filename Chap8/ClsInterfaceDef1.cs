namespace Chap8_ClsInterfaceDef;

interface ISample1
{
    // メソッドの実装が可能
    void MethodA() => Console.WriteLine("MethodA");
    void MethodB();
}

public class A : ISample1
{
    public void MethodB() => Console.WriteLine("MethodB");
}
class B : ISample1
{
    // ISample1のメソッドと同じ名前
    public void MethodA() => Console.WriteLine("B MethodA");
    public void MethodB() => Console.WriteLine("MethodB");
}

class ClsInterfaceDef1
{
    static void Main()
    {
        var c1 = new A();
        c1.MethodB();               // 出力値：MethodB
     // c1.MethodA();               // class Aにメソッドの定義はないのでエラー

        // キャストが必要
        ((ISample1)c1).MethodA();   // 出力値：MethodA

    }
}

