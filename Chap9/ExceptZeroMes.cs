namespace Chap9_ExceptZeroMes;

class ExceptZeroMes
{
    static void Main()
    {
        try
        {
            int a = 0;
            int b = 0;
            a /= b;         // ゼロ除算の例外が発生する
        }
        catch (Exception e)
        {
            // Messageプロパティの表示
            Console.WriteLine(e.Message);
        }
    }
}
