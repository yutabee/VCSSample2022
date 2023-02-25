namespace Practice6_2;

class TestClass
{
    public void TestFunc(ref int a, out int b)
    {
        b = a * a;
        a = a * a * a;
    }
    static void Main()
    {
        TestClass test = new();
        int a = 3;
        test.TestFunc(ref a, out int b);
    }
}

