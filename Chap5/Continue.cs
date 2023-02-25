namespace Chap5_Continue;

class Continue
{
    static void Main()
    {
        for (int i = 0; true; i++)
        {
            if (i < 8)
            {
                continue; // カウンタ変数を更新してループの先頭に戻る
            }
            else if (i == 10)
            {
                break; // ループを中断する
            }
            Console.WriteLine(i);
        }
    }
}

