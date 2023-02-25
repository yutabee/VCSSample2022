namespace Chap5_Fallthrough;

class Fallthrough
{
    static void Main()
    {
        int month = DateTime.Now.Month; // 現在の月を取得

        switch (month)
        {
            //case 7:
            //    Console.WriteLine( "試験" );   // C#ではエラー
            case 8:
                Console.WriteLine("夏休み");
                break;
            default:
                Console.WriteLine(month + "月");
                break;
        }
    }
}
