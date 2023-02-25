namespace Chap9_ExceptUnderflow;

class ExceptUnderflow
{
    static void Main()
    {
        checked
        {
            float x = 1e35f;
            float y = 1e-35f;

            // 例外とはならない
            Console.WriteLine(x * x);   // 出力値：+∞
            Console.WriteLine(y * y);   // 出力値：0
        }
    }
}
