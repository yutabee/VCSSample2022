namespace Chap12_GenericStack;

class GenericStack
{
    static void Main()
    {
        var st = new Stack<int>();

        // 要素を追加
        st.Push(10);
        st.Push(11);
        st.Push(12);
        st.Push(13);

        // 先頭の要素を取得して削除
        Console.WriteLine(st.Pop());    // 出力値：13
        Console.WriteLine(st.Pop());    // 出力値：12

        // 先頭の要素を取得
        Console.WriteLine(st.Peek());   // 出力値：11

        // 先頭の要素を取得して削除
        Console.WriteLine(st.Pop());    // 出力値：11

        // すべての要素の削除
        st.Clear();

        // 要素を追加
        st.Push(1);
        st.Push(2);
        st.Push(3);

        // すべての要素を順番に取得
        foreach (var i in st)
        {
            Console.WriteLine(i);
        }

        // 先頭の要素を取得して削除
        Console.WriteLine(st.Pop());    // 出力値：3
    }
}
