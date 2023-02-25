namespace Chap6_ClsMethod;

class ClsMethodRet
{
    // int型を返すメソッド
    public int MyMethod1()
    {
        return 10;
    }

    // 値を返さないメソッド
    public void MyMethod2(int a)
    {
        if (a < 3)
        {
            return;              // aが3未満ならメソッドを終了
        }

        Console.WriteLine(a); // aが3以上なら実行される
    }
}
