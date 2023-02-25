using X;

namespace X
{
    public static class StringExtender
    {
        // 拡張メソッド(16進文字列を数値型に変換)
        public static int Hex2Int(this string s)
        {
            return Convert.ToInt32(s, 16);
        }
    }
}
class ExtendStringName
{
    static void Main()
    {
        var s = "D3";
        Console.WriteLine(s.Hex2Int()); // 出力値：211
    }
}
