namespace Practice11_2;

class Sample
{
    public async Task<int> SampleAsync()
    {
        // 非同期処理を実行
        return await Task.Run(new Func<int>(() =>
        {
            // int型の最大値までインクリメントする
            int i = 0;
            for (; i < int.MaxValue; i++) { };
            return i;
        }));
    }
    public void Do()
    {
        Task<int> t = SampleAsync();

        // タスクが完了するまでアプリケーションが終了しないように待機する
        t.Wait();

        Console.WriteLine("完了：{0}", t.Result);
    }
}
class Practice
{
    static void Main()
    {
        new Sample().Do();
    }
}

