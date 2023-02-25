namespace Chap5_ForeachStmt;


class ForeachStmt
{
    static void Main()
    {
        string[] j = { "グー", "チョキ", "パー" };

        // 配列のデータを1つずつ取得
        foreach (string str in j)
        {
            System.Console.WriteLine(str);
        }
    }
}
