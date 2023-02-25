namespace Chap3_PrintChar;
class PrintChar
{
    static void Main()
    {
        char a = '\u6F22';          // '漢'の文字コード（6F22）を代入
        char b = '漢';

        Console.WriteLine(a);       // 出力値：漢
        Console.WriteLine(b);       // 出力値：漢
    }
}

