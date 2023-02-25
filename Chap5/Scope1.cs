namespace Chap5_Scope;

class Scope1
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // 変数iは存在しないというコンパイルエラーになる
        // Console.WriteLine(i);
    }
}

