namespace Chap12_GenericDictionary;

class GenericDictionary
{
    class Medal
    {
        readonly int gold;
        readonly int silver;
        readonly int bronze;

        // コンストラクタ
        public Medal(int g, int s, int b)
        {
            gold = g;
            silver = s;
            bronze = b;
        }

        // フィールドの値を出力
        public void Output()
        {
            Console.WriteLine("金：{0}, 銀：{1}, 銅：{2}", gold, silver, bronze);
        }
    }

    static void Main()
    {
        // 1：キーを文字列、値をMedalクラスとしてインスタンス化
        var win = new Dictionary<string, Medal>();

        // 2：要素を追加
        win["Japan"] = new Medal(20, 10, 8);
        win["China"] = new Medal(10, 5, 30);
        win.Add("USA", new Medal(15, 10, 2));

        // 3："USA"がキーのMedalクラスを取得して出力
        var m = win["USA"];
        m.Output();

        try
        {
            // 4："Russia"をキーとして値を取得しようとすると
            m = win["Russia"];
            m.Output();
        }
        catch (Exception e)
        {
            // "Russia"はキーにないので例外が発生
            Console.WriteLine(e.Message);
        }

        // 5："China"がキーのMedalクラスを取得して出力
        win.TryGetValue("China", out m);
        m?.Output();

        // 6："中国"はキーにないのでmは参照型の既定値であるnullとなる
        win.TryGetValue("中国", out m);
        Console.WriteLine(m == null);

        // 7：キーが存在するかどうかを確認
        if (win.ContainsKey("Japan"))
        {
            Console.WriteLine("存在");
        }

        // 8：値があるかどうかの確認
        win.TryGetValue("USA", out m);
        if (win.ContainsValue(m!))
        {
            Console.WriteLine("値あり");
        }

        // 9：キーと値を列挙
        foreach (KeyValuePair<string, Medal> kp in win)
        {
            Console.Write("{0} 　", kp.Key);
            kp.Value.Output();
        }
        // タプルにすることもできる
        foreach (var (k, v) in win)
        {
            Console.Write("{0} 　", k);
            v.Output();
        }
    }
}
