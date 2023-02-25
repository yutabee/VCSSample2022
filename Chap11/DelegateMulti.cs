namespace Chap11_DelegateMulti;

class DelegateMulti
{
    // デリゲートの定義
    delegate int SampleDel(int x);

    class TestClass
    {
        public int TestMethod1(int n)
        {
            return n * 10;
        }

        public int TestMethod2(int n)
        {
            return n * 20;
        }
    }
    public static void Main()
    {
        var t = new TestClass();

        SampleDel? delVar = t.TestMethod1;

        // TestMethod2を追加
        delVar += t.TestMethod2;

        // TestMethod1とTestMethod2が実行される
        Console.WriteLine(delVar(10));     // 出力値：200

        // TestMethod2の削除
        delVar -= t.TestMethod2;

        if (delVar != null)
        {
            // TestMethod1のみ実行される
            Console.WriteLine(delVar(10));    // 出力値：100
        }
    }
}

