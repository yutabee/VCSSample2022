namespace Chap3_PrintEnum;

enum Day
{
    Sun, Mon, Tue, Wed, Thu, Fri, Sat
}
class PrintEnum
{
    static void Main()
    {
        Console.WriteLine(Day.Sun);      // 出力値：Sun
        Console.WriteLine((int)Day.Sat); // 出力値：6
    }
}

