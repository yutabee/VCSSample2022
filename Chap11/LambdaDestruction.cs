namespace Chap11_LambdaDestruction;

class LambdaDestruction
{
    public static void Main()
    {
        // _は、パラメーターとして使える
        Func<int, int, int> func1 = (_, p) => _ * p;

        // _は、破棄の意味になる
        Func<int, int, int> func2 = (_, _) => 0;

        Console.WriteLine(func1(5, 2)); // 出力値：10
        Console.WriteLine(func2(5, 2)); // 出力値：0
    }
}
