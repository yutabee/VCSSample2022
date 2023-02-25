namespace Chap12_SpanUnsafe;

class SpanUnsafe
{
    static void Main()
    {
        try
        {
            unsafe
            {
                int* x = stackalloc int[3];
                x[5] = 1; // エラーとならない
            }

            // Span<T>構造体でスタック上の配列を参照する
            Span<int> sp = stackalloc int[] { 0, 1, 2 };
            sp[5] = 1; // 実行時にエラーとなる
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

