// 名前を入力して表示するプログラム#1
class First
{
    static string program_ver = "sample #1";

    static void Main()
    {
        System.Console.WriteLine(program_ver);
        System.Console.Write("お名前は？≫ ");
        string? name = System.Console.ReadLine();
        System.Console.WriteLine($"ようこそ、{name}さん !");
    }
}