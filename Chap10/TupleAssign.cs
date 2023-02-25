namespace Chap10_TupleAssign;
class TupleAssign
{
    static void Main()
    {
        (int n, string name) t1 = (1, "sample");
        (int num, string str) t2 = (3, "テスト");

        // タプル型変数の代入
        t1 = t2;
        Console.WriteLine(t1.name);  // 出力値:テスト

        // タプルの代入(エラー、キャストが必要)
        // (byte n, string name) t3 = (3, "テスト");
        // t3 = t1;
    }
}

