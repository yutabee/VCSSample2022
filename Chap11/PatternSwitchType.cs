namespace Chap11_PatternSwitchType;

class PatternSwitchType
{
    static void Main()
    {
        object test = "test";

        // 型のパターンマッチング
        var str = test switch
        {
            // int _ => "int", // C#8での書き方
            int => "int",
            long => "long",
            string => "string",
            _ => "none"
        };
        Console.WriteLine(str);// 出力値：string
    }
}



