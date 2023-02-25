namespace Chap10_StructInit;

struct Simple
{
    public int Number;
    public string Name;
}

class StructInit
{
    static void Main()
    {
        Simple ss;         // newは不要

        ss.Number = 0;     // int型のフィールドに値を設定
        ss.Name = "test";  // string型のフィールドに値を設定

        Console.WriteLine(ss.Number);   // 出力値：0
        Console.WriteLine(ss.Name);     // 出力値：test
    }
}
