namespace Chap6_ClsRefEase;

class ClsRefEaseFor
{
    static void Main()
    {
        string[] j = { "グー", "チョキ", "パー" };

        int s = 0;
        for (ref int i = ref s; i < j.Length; i++)
        {
            Console.WriteLine(j[i]);
        }
        Console.WriteLine(s);               // 出力値：3
    }
}
