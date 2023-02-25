namespace Chap10_RecordStruct;

class RecordStruct
{
    // レコード構造体
    record struct Rstruct(int X, int Y);

    // レコードクラス（C# 9.0のrecord）
    record class Rclass(int X, int Y);

    // 構造体
    struct NormalStruct
    {
        public int X = -1;
        public int Y = -1;
    }

    static void Main()
    {
        // レコード構造体
        var rs = new Rstruct { X = 2 };
        Console.WriteLine(rs);// 出力値:Rstruct { X = 2, Y = 0 }

        // 書き換え可能
        rs.Y = 2;
        Console.WriteLine(rs);// 出力値:Rstruct { X = 2, Y = 2 }

        // レコード
        var rc = new Rclass(0,0);
        Console.WriteLine(rc);// 出力値:Rclass { X = 0, Y = 0 }

        // エラーとなる（レコードでは書き換えできない）
        // rc.Y = 2;
        // Console.WriteLine(rc.Y);// 出力値:2

        // 構造体
        var ns = new NormalStruct { X = 2 };
        Console.WriteLine(ns.X);// 出力値:2
        Console.WriteLine(ns.Y);// 出力値:-1
        Console.WriteLine(ns);
        // 出力値:Chap10_RecordStruct.RecordStruct + NormalStruct
    }
}
