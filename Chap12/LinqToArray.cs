namespace Chap12_Linq;

class LinqToArray
{
    static void Main()
    {
        // string型のリスト
        var names = new List<string>() { "Tigers", "Giants", "Dragons" };

        // LINQにより取得したデータを配列に変換
        var result = (from n in names select n).ToArray();

        // 取得したデータを出力
        foreach (var x in result)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("");

        // names[1]とnames[2]を入れ替える
        string tmp = names[1];
        names[1] = names[2];
        names[2] = tmp;

        // 再びデータを出力
        foreach (var x in result)
        {
            Console.WriteLine(x);
        }
    }
}

