namespace Chap10_TupleLiteral;

class TupleLiteral
{
    static void Main()
    {
        // タプル型の戻り値
        (string name, int age) GetMember()
        {
            var n = "Wings";
            var a = 18;
            return (n, a);
        }
        // (string , int) GetMember() と書ける

        var m = GetMember();
        Console.WriteLine(m.Item1); // 出力値: Wings
        Console.WriteLine(m.Item2); // 出力値: 18
    }
}

