namespace Chap11_LambdaThrow;

class LambdaThrow
{
    // ラムダ式の=>演算子の後
    static public int Throw1() => throw new Exception("Lambda");

    static public string Throw2(int ct)
    {
        // 条件演算子の第2または第3引数
        return (ct < 0) ? throw new InvalidOperationException("nothing") : ct.ToString();
    }

    public static void Main()
    {
        try
        {
            Throw1();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        try
        {
            Throw2(-1);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            object? sample_var = null;

            // null合体演算子の後
            var s = sample_var as string ?? throw new Exception();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
