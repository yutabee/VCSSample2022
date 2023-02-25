namespace Chap6_ClsConstructor;

class Car
{
    // データメンバー
    public string name = "";
    public int seats;

    // 既定のコンストラクター
    public Car()
    {
        seats = 4; // 4で初期化
    }

    // string型のパラメータを受け取るコンストラクター
    public Car(string str)
    {
        seats = 4;
        name = str;
    }

}

class ClsConstructor
{
    static void Main()
    {
        var test = new Car();
        Console.WriteLine(test.name);   // 何も出力されない

        var test2 = new Car("マイカー");
        Console.WriteLine(test2.name);  // 出力値：マイカー
    }
}