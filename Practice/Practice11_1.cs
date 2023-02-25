namespace Practice11_1;

class Sample
{
    // 指定の数までの乱数を返す（ラムダ式）
    public int Random(int s) => new Random().Next(s);

    // 指定の数までの乱数を返す
    public int Random_q(int s)
    {
        return new Random().Next(s);
    }
}
class Practice
{
    static void Main()
    {
        Console.WriteLine(new Sample().Random(10));
    }
}

