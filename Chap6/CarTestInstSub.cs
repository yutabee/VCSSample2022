namespace Chap6_CarTest;

class CarTestInstSub
{
    static void Main()
    {
        Car mycar1 = new Car();
        Car mycar2 = new Car();
        Car mycar3 = mycar2; // インスタンスの代入

        mycar3.name = "サブカー"; // mycar3のメンバーを変更

        Console.WriteLine(mycar3.name);      // 出力値：サブカー
        Console.WriteLine(mycar2.name);      // 出力値：サブカー

        // インスタンスを比較すると
        Console.WriteLine(mycar2 == mycar3); // 出力値：True
    }
}

