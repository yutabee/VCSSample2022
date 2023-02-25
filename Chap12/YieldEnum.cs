namespace Chap12_YieldEnum;

class YieldEnum
{
    static void Main()
    {
        // 1～numberまでを列挙する関数
        IEnumerable<int> factorial(int number)
        {
            for (int i = number; 0 < i; i--)
            {
                yield return i;
            }
        }

        foreach (int v in factorial(3))
        {
            Console.WriteLine(v);
        }
    }

}

