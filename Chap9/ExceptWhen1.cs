namespace Chap9_ExceptWhen;

class ExceptWhen1
{
    static void Main()
    {
        try
        {
            throw new Exception("error");
        }
        catch (Exception e) when (e.Message == "error")
        {
            Console.WriteLine("エラー発生");
        }
        // Message プロパティが "error" 以外のとき
        catch (Exception e)
        {
            Console.WriteLine("その他の例外");
        }
    }
}
