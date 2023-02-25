namespace Practice10_3;

class Practice
{
    static void Main()
    {
        // 最大値とその次の数を求める
        (int, int) GetMaxNext(int[] arr)
        {
            // 要素数が2以上のとき
            if (arr.Length >= 2)
            {
                // 昇順に並べる
                Array.Sort(arr);
                return (arr[arr.Length - 1], arr[arr.Length - 2]);
            }
            else
            {
                return (-1, -1);
            }
        }

        // 実行例
        var arr1 = new int[] { 1, 3, 5 };
        var (v1, v2) = GetMaxNext(arr1);
        Console.WriteLine("{0},{1}", v1, v2);
    }
}

