namespace Chap6_ClsRefEase;

class ClsRefReSub
{
    static void Main()
    {
        var test = new TestClass();

        int e = 1;
        int f = 2;
        ref int g = ref e;

        g = 5;
        // eの値が書き換わる
        Console.WriteLine(e);               // 出力値：5

        // 再代入（参照先を変数fに変更）
        g = ref f;
        g = 10;

        // fの値が書き換わる
        Console.WriteLine(f);               // 出力値：10
                                            // eの値はそのまま
        Console.WriteLine(e);               // 出力値：5
    }
}
