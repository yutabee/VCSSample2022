namespace Chap6_ClsStaticConst;

class Car
{
    public string name;       // インスタンスメンバー
    public static int seats;  // 静的メンバー

    public Car()
    {
        name = "マイカー";
        Console.WriteLine(name);
    }

    // 静的コンストラクター
    static Car()
    {
        seats = 4;
        Console.WriteLine(seats);
    }

    // 静的メソッド
    public static void SetSeat(int n)
    {
        seats = n; // 静的メンバーに代入
    }

    public void Display()
    {
        Console.WriteLine(seats); // 静的メソッドの呼び出し
    }
}

class ClsStaticConst
{
    static void Main()
    {
        var test = new Car();  // 静的コンストラクターと既定のコンストラクターが呼び出される

        Car.SetSeat(5);        // 静的メンバーに5を設定

        var test2 = new Car(); // 既定のコンストラクターのみが呼び出される

        test2.Display();       // 静的メンバーの値は変更されていない
    }
}
