namespace Practice10_1;

class Practice
{
    static void Main()
    {
        var arr1 = new int[] { 1, 3, 5 };
        var arr2 = new int[] { 2, 4, 6 };

        var arr3 = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr3[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            arr3[arr1.Length + i] = arr2[i];
        }

        // 昇順にソートする
        Array.Sort(arr3);
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.WriteLine(arr3[i]);
        }
    }
}

