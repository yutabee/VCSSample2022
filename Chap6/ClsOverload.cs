namespace Chap6_ClsOverload;

class TestClass
{
    // 2つのint型の整数を加算するメソッド
    long AddNums(int a, int b)
    {
        return a + b;
    }

    // 3つのint型の整数を加算するメソッド
    long AddNums(int a, int b, int c)
    {
        return a + b + c;
    }

    // 2つのlong型の整数を加算するメソッド
    long AddNums(long a, long b)
    {
        return a + b;
    }

    // 2つの参照渡しのint型の整数を加算するメソッド
    long AddNums(ref int a, int b)
    {
        return a + b;
    }
}
