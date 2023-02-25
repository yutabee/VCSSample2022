namespace Chap10_StructArray;

// 構造体
struct Player
{
    public string Name;     //名前
    public int Number;      //背番号
    public string Position; //ポジション名

    // パラメータ付きのコンストラクタ
    public Player(int n, string s, string p)
    {
        Number = n;
        Name = s;
        Position = p;
    }
}

// 構造体の配列をメンバに持つクラス
class Team
{
    // 配列regularにコピーしたデータ数
    int regularcnt;

    // Player型の配列、サイズは3
    readonly Player[] regular = new Player[3];

    // 配列regularに追加（構造体のパラメータ）
    public bool AddRegular(Player p)
    {
        // 配列のサイズに達するまで追加できる
        if (regularcnt < regular.Length)
        {
            // Player型のデータをコピー
            regular[regularcnt++] = p;
            return true;
        }
        return false;
    }

    // 配列regularの要素を表示
    public void ShowRgular()
    {
        foreach (var p in regular)
        {
            // 名前があるものだけ表示
            if (p.Name != null)
            {
                Console.WriteLine("{0} {1} {2}", p.Name, p.Number, p.Position);
            }
        }
    }

    // 配列regularの要素を返す（構造体の戻り値）
    public Player GetRegular(int ix)
    {
        try
        {
            return regular[ix];
        }
        catch
        {
            // 範囲外のインデックスなら、空のPlayerを返す
            return new Player();
        }
    }
}

class StructArray
{
    static void Main()
    {
        var t = new Team();

        // Player型のデータを追加
        t.AddRegular(new Player(53, "青星", "センター"));
        t.AddRegular(new Player(6, "鉄本", "レフト"));
        t.AddRegular(new Player(1, "島谷", "ショート"));
        t.AddRegular(new Player(39, "矢田", "キャッチャー"));

        // 追加したPlayerを表示
        t.ShowRgular();

        // インデックスを指定してPlayerを取得
        var p = t.GetRegular(1);
        Console.WriteLine(p.Name);

        // インデックスが範囲を超えた場合
        p = t.GetRegular(5);
        Console.WriteLine(p.Name); // 何も表示されない
    }
}
