namespace Chap5_ForError;

class ForError
{
    static void Main()
    {
        string[] j = { "グー", "チョキ", "パー" };

        // 配列の範囲を超えているので、実行時にエラーとなる。
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine(j[i]);
        }
    }
}