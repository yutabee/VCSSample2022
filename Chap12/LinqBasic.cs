namespace Chap12_Linq;

class LinqBasic
{
    static void Main()
    {
        // 数値型の配列データ
        int[] num = { 1, 2, 9, 28, 30, 31, 15, 42 };

        // 30未満を抽出（LINQのクエリ式）
        var numsQuery = from n in num
                        where n < 30
                        select n;

        // 結果データを表示
        foreach (var x in numsQuery)
        {
            Console.Write("{0}, ", x);
        }

        Console.WriteLine();

        // 3の倍数を抽出（LINQのメソッド構文）
        var numsMethod = num.Where(x => (x % 3) == 0);

        // 結果データを表示
        foreach (var x in numsMethod)
        {
            Console.Write("{0}, ", x);
        }
    }
}

