namespace Chap9_ExceptZeroFinally;

class ExceptZeroFinally
{
    static void Main()
    {
        try
        {
            int a = 0;
            int b = 0;
            a /= b;         // ゼロ除算の例外が発生する
        }
        catch
        {
            Console.WriteLine("例外発生");
        }
        finally
        {
            Console.WriteLine("終了");
        }
    }
}
