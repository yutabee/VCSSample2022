namespace Chap9_ExceptReThrow;

class MainClass
{
    static void Main()
    {
        try
        {
            // tryブロックのネスト
            try
            {
                int[] a = new int[3];

                a[0] = 1;
                a[5] = 2;       // 例外（範囲外にアクセス）
            }
            catch (Exception)
            {
                Console.WriteLine("最初の捕捉");
                throw;
            }
        }
        catch (Exception e)    // すべての例外の捕捉
        {
            Console.WriteLine("外側の捕捉");
            Console.WriteLine(e.Message);
        }
    }
}
