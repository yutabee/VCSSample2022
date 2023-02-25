namespace Chap11_ThreadResult;

class ThreadResult
{
    // 非同期メソッド
    public static async Task<long> ThreadMethodAsync()
    {
        long val = 0;

        // Task<long>型を返す
        return await Task.Run(() =>
        {
            for (long i = 1; i <= 1000000000; i++)
            {
                val += i;
            }
            // long型の値を返す
            return val;
        });
    }

    public static void Main()
    {
        Console.WriteLine("start");

        Task<long> t = ThreadMethodAsync();

        // タスクが完了するまでアプリケーションが終了しないように待機する
        t.Wait();

        // 結果の表示
        Console.WriteLine(t.Result); // 出力値：500000000500000000
    }
}
