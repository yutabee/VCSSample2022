namespace Chap9_ExceptReThrow;

class ExceptReThrow1
{
    // catchブロックで例外をスローするメソッド
    static void ExceptionMethod()
    {
        try
        {
            // 配列の宣言
            int[] a = new int[3];

            a[0] = 1;
            a[5] = 2;       // 例外（範囲外にアクセス）
        }
        catch (Exception)
        {
            Console.WriteLine("最初の捕捉");

            // 例外を再スロー
            throw new IndexOutOfRangeException();
        }
    }

    static void Main()
    {
        try
        {
            // 例外がスローされるメソッドの呼び出し
            ExceptionMethod();
        }
        catch (Exception e)   // すべての例外の捕捉
        {
            Console.WriteLine("外側の捕捉");
            Console.WriteLine(e.Message);
        }
    }
}
