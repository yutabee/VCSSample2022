namespace Chap6_ClsOverloadErr;

class TestClass
{
    // int型の値を返すメソッド
    int AddNums(int a, int b)
    {
        return a + b;
    }
    /*
            // 戻り値のデータ型が異なってもパラメータのデータ型が同じなのでエラー
            long AddNums(int c, int d)
            {
                return c + d;
            }
    */
    long AddNums(out int a, int b)
    {
        a = b;
        return a;
    }
    /*
            // refとoutが異なっても同じデータ型となるのでエラー
            long AddNums(ref int a, int b)
            {
                return a + b;
            }
    */
}
