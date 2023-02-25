namespace Chap11_Threadpool;

class Threadpool
{
    static void Main()
    {
        // スレッドで実行する処理
        void testThread(Object? stateInfo)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stateInfo + " " + i);
                Thread.Sleep(200);
            }
        }

        // WaitCallbackデリゲートを使ってスレッドプールにメソッドを登録する
        ThreadPool.QueueUserWorkItem(new WaitCallback(testThread), "1");
        ThreadPool.QueueUserWorkItem(new WaitCallback(testThread), "2");
        ThreadPool.QueueUserWorkItem(new WaitCallback(testThread), "3");

        // アプリケーションが終了しないように待機する
        Console.ReadLine();
    }
}
