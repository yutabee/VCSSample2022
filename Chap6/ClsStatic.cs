namespace Chap6_ClsStatic;

class Car
{
    public string name;       // インスタンスメンバー
    public static int seats;  // 静的メンバー

    public Car()
    {
        name = "マイカー";
    }

    public void Display()
    {
        Console.WriteLine(seats); // seats静的フィールドの値を出力
    }
}

class ClsStatic
{
    static void Main()
    {
        Car.seats = 5;   // seats静的フィールドに5を設定

        // インスタンスを作成
        var test = new Car();
        test.Display();  // 出力値：5

        // 別のインスタンスでも静的フィールドの値は同じになる
        var test2 = new Car();
        test2.Display(); // 出力値：5
    }
}
