using System;
namespace Chap7_ClsInitializers;

class SampleClass
{
    // フィールド
    public int v1 = 10;
    private int v2;

    // デフォルトコンストラクタ
    public SampleClass()
    {
        Console.WriteLine(this.v1);
    }

}

class ClsInitializers
{
    static void Main()
    {
        var test = new SampleClass { v1 = 20 }; // 出力値：10
        Console.WriteLine(test.v1);             // 出力値：20

        // 以下のコメントをはずすとコンパイルエラーとなる
        // privateのメンバは設定できない
        // var test2 = new SampleClass { v2 = 20 };
    }
}
