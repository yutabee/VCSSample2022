namespace Chap5_Break;

class Break
{
    static void Main()
    {
        for (int i = 0; true; i++)
        {
            if (i == 3)  // 変数iが3の場合
            {
                break;     // ループを中断する
            }
            Console.WriteLine(i);
        }
    }
}

