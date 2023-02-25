using System.Collections;
namespace Chap12_GenericSorted;

public class GenericSorted
{
    // 独自の比較処理
    public class MyReverserClass : IComparer
    {
        int IComparer.Compare(Object? x, Object? y)
        {
            // パラメータを逆にして比較した結果を返す
            return ((new CaseInsensitiveComparer()).Compare(y, x));
        }
    }

    public static void Main()
    {
        // SortedListに独自の比較処理を組み込む
        var myList = new SortedList(new MyReverserClass())
            {
                { "1st", "Tigers" },
                { "2nd", "Giants" },
                { "3rd", "Dragons" }
            };

        for (int i = 0; i < myList.Count; i++)
        {
            // キーと値を表示
            Console.WriteLine("[{0}]{1}", myList.GetKey(i), myList.GetByIndex(i));
        }
    }
}

