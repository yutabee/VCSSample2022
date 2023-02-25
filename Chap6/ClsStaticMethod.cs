namespace Chap6_ClsStaticMethod;


class Car
{
    public string name;       // インスタンスメンバー
    public static int seats;  // 静的メンバー

    public Car()
    {
        name = "マイカー";
    }

    // 静的メソッド
    public static void SetSeat(int n)
    {
        seats = n; // 静的メンバーのみアクセス可能
    }

    public void Display()
    {
        Console.WriteLine(seats); // 静的メソッドの呼び出し
    }
}

class ClsStaticMethod
{
    static void Main()
    {
        Car.SetSeat(5); // 静的メンバーに5を設定

        var test = new Car();
        test.Display();  // 出力値：5

        var test2 = new Car();
        test2.Display(); // 出力値：5
    }
}
