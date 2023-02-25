namespace Chap12_GenericQueue;

class GenericQueue
{
    static void Main()
    {
        var q = new Queue<int>();

        // 要素を追加
        q.Enqueue(10);
        q.Enqueue(11);
        q.Enqueue(12);
        q.Enqueue(13);

        // 先頭の要素を取得して削除
        Console.WriteLine(q.Dequeue());    // 出力値：10
        Console.WriteLine(q.Dequeue());    // 出力値：11

        // 先頭の要素を取得
        Console.WriteLine(q.Peek());       // 出力値：12

        // 先頭の要素を取得して削除
        Console.WriteLine(q.Dequeue());    // 出力値：12

        // すべての要素の削除
        q.Clear();

        // 要素を追加
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        // すべての要素の取得
        foreach (var i in q)
        {
            Console.WriteLine(i);
        }

        // 先頭の要素を取得して削除
        Console.WriteLine(q.Dequeue());    // 出力値：1
    }
}
