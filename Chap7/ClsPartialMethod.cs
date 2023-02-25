namespace Chap7_ClsPartialMethod;

partial class Sample
{
    static partial void LogInfo();

    static void Main()
    {
        LogInfo();

        Console.WriteLine("Hello"); // 出力値：Hello
    }
}