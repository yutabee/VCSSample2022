using System.Globalization;
namespace Column;

class Wareki
{
    static void Main()
    {
        var ci = new CultureInfo("ja-JP");
        ci.DateTimeFormat.Calendar = new JapaneseCalendar();

        var d1 = new DateTime(2019, 5, 1);
        Console.WriteLine(d1.ToString("yyyy年MM月dd日"));   // 出力値：2019年05月01日
        Console.WriteLine(d1.ToString("gy年MM月dd日", ci)); // 出力値：令和元年05月01日

    }
}

