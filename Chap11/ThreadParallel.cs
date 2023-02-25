namespace Chap11_ThreadParallel;

class ThreadParallel
{
    // スレッドで実行したい処理
    static public void ThreadMethod()
    {
        // 3秒間停止する
        Thread.Sleep(3000);
        Console.WriteLine("finish");
    }

    public static void Main()
    {
        Console.WriteLine("start");

        // InvokeメソッドにActionデリゲートを渡す
        Parallel.Invoke(new Action(ThreadMethod),
           () =>
           {
               // 5秒間停止する
               Thread.Sleep(5000);
               Console.WriteLine("finish");
           });
    }
}
