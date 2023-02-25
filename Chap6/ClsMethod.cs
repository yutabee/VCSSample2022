namespace Chap6_ClsMethod;

class ClsMethod
{
    // 値を返さない、パラメーターのないメソッド
    public void PrintOne()
    {
        Console.WriteLine("1");
    }

    static void Main()
    {
        var test = new ClsMethod();   // インスタンス生成
        test.PrintOne();              // printOneメソッド呼び出し
                                      // 出力値：1
    }
}
