using System;
namespace Chap7_ClsIndexer;

class TestArray
{
    // privateなので外部からはアクセスできない
    int[] array = new int[3];

    // インデクサーの定義
    public int this[int index]
    {
        set
        {
            array[index] = value;
        }
        get
        {
            return array[index];
        }
    }
}

class ClsIndexer
{
    static void Main()
    {
        var t = new TestArray();

        // 配列のように代入できる
        t[0] = 5;
        t[1] = 10;
        t[2] = 15;

        // 配列のように参照できる
        Console.WriteLine(t[1]); // 出力値：10

        // オブジェクト初期化子でのインデクサー
        var t2 = new TestArray()
        {
            [0] = 5,
            [1] = 10,
            [2] = 15
        };
        Console.WriteLine(t2[2]); // 出力値：15
    }

}
