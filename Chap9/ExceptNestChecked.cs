namespace Chap9_ExceptNestChecked;

class ExceptNestChecked
{
    static void Main()
    {
        try
        {
            ushort x = 300;             // 300 = 256 + 44
            byte y;

            unchecked
            {
                y = (byte)x;            // byte型に変換するとオーバーフローする
                Console.WriteLine(y); // 出力値: 44

                checked
                {
                    y = (byte)x;        // オーバーフロー例外のスロー
                    Console.WriteLine(y);
                }
            }
        }
        catch (OverflowException e)   // オーバーフロー例外の捕捉
        {
            Console.WriteLine(e.Message);
        }
    }
}
