namespace Chap7_ClsAutoProp;

class SampleClass
{
    // 自動で内部的なstring型のフィールドが生成される
    public int Type { get; set; }
}

class ClsAutoProp
{
    static void Main()
    {
        var test = new SampleClass();

        test.Type = 1;
        Console.WriteLine(test.Type); // 出力値：1
    }
}

