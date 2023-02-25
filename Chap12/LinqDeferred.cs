namespace Chap12_Linq;

class LinqDeferred
{
    static void Main()
    {
        // stringのLIST
        var names = new List<string>() { "Tigers", "Giants", "Dragons" };

        // LINQによるデータ抽出
        var result = from n in names select n;

        // 結果データを表示（1）
        foreach (var x in result)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("");

        // names[1]とnames[2]を入れ替える
        string tmp = names[1];
        names[1] = names[2];
        names[2] = tmp;

        // 結果データを表示（2）
        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}
