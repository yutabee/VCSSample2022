namespace Chap7_ClsPartial;

    partial class Sample
    {
        int a = 1;
    }

    partial class Sample
    {
        public void test()
        {
            Console.WriteLine(a);
        }
    }

class ClsPartial
{
    static void Main()
    {
        var testClass = new Sample();

        testClass.test();  // 出力値：1
    }
}
