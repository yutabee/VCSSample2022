namespace Chap12_YieldReturn;

class YieldReturn
{
    static void Main()
    {
        // 1～numberまでを列挙する関数
        IEnumerable<int> factorial(int number)
        {
            if ((number < 1) || (100 < number))
            {
                Console.WriteLine("error");
                yield break;

            }
            for (int i = number; 0 < i; i--)
            {
                yield return i;
            }
        }

        foreach (int v in factorial(101))
        {
            Console.WriteLine(v);
        }
    }

}

