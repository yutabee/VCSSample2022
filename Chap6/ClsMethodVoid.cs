namespace Chap6_ClsMethod;

class ClsMethodVoid
{
    // 値を返さないメソッド
    public void MyMethod3(int a)
    {
        if (a < 3)
        {
            // return 2;   // voidなのに戻り値を書くとエラーになる
        }
        return;         // これはエラーにならない
    }

    /*
    // int型の値を返すメソッド
    public int MyMethod4(int a)
    {
        if (a < 3)
        {
            return;     // 値が必要
        }
        // 値を返すメソッドではreturn文は省略できない
    }
    */
}
