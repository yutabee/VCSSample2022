namespace Chap8_ClsInterfaceDef;

class ClsInterfaceDef2
{
    static void Main()
    {
        var c2 = new B();
        c2.MethodA();               // 出力値：B MethodA

        // キャストしてもclass Bのメソッドが優先される
        ((ISample1)c2).MethodA();   // 出力値：B MethodA
    }
}

