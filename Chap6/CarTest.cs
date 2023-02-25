namespace Chap6_CarTest;

class Car
{
    // フィールド
    public string name = "";
    public int seats = 4;
}
class CarTest
{
    static void Main()
    {
        Car mycar = new Car();            // Carクラスのインスタンスを生成
        mycar.name = "マイカー";          // .でデータメンバーを指定
        Console.WriteLine(mycar.name);    // 出力値：マイカー
        Console.WriteLine(mycar.seats);   // 出力値：4
    }
}