namespace Chap10_TupleDeconstruction;

class TupleDeconstruction
{
    static void Main()
    {
        // タプル型の戻り値
        (string name, int age) GetMember()
        {
            var n = "Wings";
            var a = 18;
            return (n, a);
        }

        // 戻り値のタプルを分解し、2つの変数に代入する
        (string name, int age) = GetMember();
        Console.WriteLine(name); // 出力値: Wings
        Console.WriteLine(age);  // 出力値: 18

        // 型推論
        (var name1, var age1) = GetMember();
        // 以下のようにも書ける
        // var ( name1, age1 ) = GetMember();

        // 不要な値は_で受け取る
        (_, int age2) = GetMember();
        Console.WriteLine(age2);  // 出力値: 18

    }
}

