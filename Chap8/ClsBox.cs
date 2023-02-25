namespace Chap8_ClsBox;

class ClsBox
{
    static void Main()
    {
        int a = 5;            // 値型の定義
        object obj;           // object型の参照変数

        obj = a;              // ボックス化
        var b = (int)obj;     // ボックス化解除

        Console.WriteLine(b); // 出力値：5

        // 元はint型なので実行時にエラーとなる
        // var d = (double)obj; 

        Console.WriteLine(obj is double); // 出力値：False
        Console.WriteLine(obj is int);    // 出力値：True
    }
}
