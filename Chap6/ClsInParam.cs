namespace Chap6_ClsInParam;

class ClsInParam
{
    public static void Main()
    {
        void TestMethod(in int num, out string s)
        {
            // 以下のように値を変更すると、エラーとなる
            // num = 48;

            if (num == 46)
            {
                s = "keyaki";
            }
            else
            {
                s = "abc";
            }
        }

        var n = 46;
        var str = "none";

        TestMethod(n, out str); // inキーワードは省略できる

        Console.WriteLine(str); // 出力値：keyaki
    }
}
