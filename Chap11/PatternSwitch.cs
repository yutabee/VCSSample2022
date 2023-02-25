namespace Chap11_PatternSwitch;

class PatternSwitch
{
    static void Main()
    {
        //var month = DateTime.Now.Month; // 現在の月を取得
        var month = 8;

        var str = month switch
        {
            1 => "睦月",
            2 => "如月",
            3 => "弥生",
            _ when month == 8 || month == 7 => "夏休み",
            _ => month + "月"
            // var m => m + "月" でも可能
        };
        Console.WriteLine(str);
    }
}
