namespace Chap6_ClsVariable;

class TestClass
{
    // int型の可変パラメーターを合計する
    public int SumAll(params int[] numary)
    {
        int sum = 0;

        // numaryの要素をforeachで取り出して合計する
        foreach (int n in numary)
        {
            sum += n;
        }

        return sum; // 合計値を返す
    }
}

class ClsVariable
{
    static void Main()
    {
        var test = new TestClass();

        Console.WriteLine(test.SumAll(1, 2));       // 出力値：3
        Console.WriteLine(test.SumAll(5, 10, 15));  // 出力値：30
        Console.WriteLine(test.SumAll());           // 出力値：0
    }
}
