namespace Chap12_GenericList;

class GenericLinkedList
{
    static void Main()
    {
        // LinkedListクラスの利用
        var list = new LinkedList<string>();

        // 1つ目の要素を追加
        list.AddFirst("First");

        // 2つ目の要素を追加
        list.AddFirst("Last");

        for (int i = 0; i < 3; i++)
        {
            // 先頭の要素の後にiの値を文字列に変換したものを追加
            list.AddAfter(list.First!, i.ToString());
        }

        // すべての要素を順番に表示
        foreach (var s in list)
        {
            Console.WriteLine(s);
        }
    }
}

