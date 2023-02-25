namespace Chap7_ClsPartialMethod;

partial class SampleEx
{
    public partial DateTime DateInfo(); // 宣言のみ
}

class ClsPartialMethodImpEx
{
    static void Main()
    {
        Console.WriteLine(new SampleEx().DateInfo()); // 出力値：(現在日時)
    }
}