namespace Chap10_ArrayLoop;

    class ArrayLoop
{
    static void Main()
    {
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        for (var i = 0; i < weekDays.Length; i++)
        {
            // 配列の要素をすべて出力
            Console.WriteLine(weekDays[i]);
        }

        foreach (string s in weekDays)
        {
            // 配列の要素をすべて出力（forループと結果は同じ）
            Console.WriteLine(s);
        }

        // 配列の要素の合計を求める
        int[] a = { 1, 2, 3 };
        var sum = 0;
        for (var i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        Console.WriteLine(sum); // 出力値：6
    }
}
