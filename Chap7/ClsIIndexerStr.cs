namespace Chap7_ClsIIndexerStr;

class ClsIIndexerStr
{
    static void Main()
    {
        var dict = new Dictionary<string, string>();

        dict["Mon"] = "月";  // インデックス"Mon"と要素"月"を追加
        dict["Tue"] = "火";  // インデックス"Tue"と要素"火"を追加

        Console.WriteLine(dict["Mon"]); // 出力値：月
    }
}

