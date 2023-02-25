namespace Chap6_ClsInstMem;

    class Car
    {
        // フィールド
        public string name = "マイカー"; // インスタンスメンバーを初期化
        public int seats;
    }

class ClsInstMem
{
    static void Main()
    {
        var test = new Car();
        var test2 = new Car();

        test2.name = "サブ";     // インスタンスメンバーに代入

        Console.WriteLine(test.name);  // 出力値："マイカー"
        Console.WriteLine(test2.name); // 出力値："サブ"
    }
}
