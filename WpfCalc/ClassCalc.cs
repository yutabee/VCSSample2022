using System;

namespace WpfCalc
{
    // 電卓クラス
    internal class ClassCalc
    {
        // 計算結果のプロパティ
        public string Result { get; private set; } = "";

        // 計算対象値保存
        Decimal Operand = 0;

        // 計算ボタンが押された直後かどうか
        bool CmdKey = false;

        // デリゲートのインスタンス化
        Func<Decimal, Decimal> DeleCalc = d => d;

        // コンストラクタ
        public ClassCalc()
        {
            ClrKey();
        }

        // 計算ボタンが押されたときの処理
        void CmdKeyMethod(Func<Decimal, Decimal> p)
        {
            decimal result = 0;

            try
            {
                // 現在表示されている数値をパラメーターとして計算処理を呼び出す
                result = DeleCalc(decimal.Parse(Result));
            }
            catch
            {
                // 例外時は、0とする
                result = 0;
            }

            Result = String.Format("{0:0.##########}", result);

            // 次回の計算処理を設定
            DeleCalc = p;

            // 計算ボタンなので
            CmdKey = true;
        }

        // 「+」ボタン
        public void PlusKey()
        {
            // ＋計算のラムダ式を渡す
            CmdKeyMethod((d) => Operand += d);
        }

        // 「-」ボタン
        public void MinusKey()
        {
            // －計算のラムダ式を渡す
            CmdKeyMethod((d) => Operand -= d);
        }

        // 「*」ボタン
        public void MultiKey()
        {
            // ＊計算のラムダ式を渡す
            CmdKeyMethod((d) => Operand *= d);
        }

        // 「/」ボタン
        public void DivisionKey()
        {
            // ／計算のラムダ式を渡す
            CmdKeyMethod((d) => Operand /= d);
        }

        // 「=」ボタン
        public void EnterKey()
        {
            // ＝計算のラムダ式を渡す
            CmdKeyMethod((d) => Operand = d);
        }

        // 「C」ボタン
        // 表示クリア（初期化）
        public void ClrKey()
        {
            Result = "0";
            Operand = 0;

            // 初期設定として、代入のラムダ式を設定
            DeleCalc = (d) => Operand = d;
        }

        // 数字ボタン
        public void NumKey(int n)
        {
            // 計算ボタンが押されていたら
            if (CmdKey == true)
            {
                // 表示の数字を置き換える
                Result = n.ToString();

                // 計算ボタンではないので
                CmdKey = false;
            }
            // 表示が0で、小数点がなければ
            else if (decimal.Parse(Result) == 0 && !Result.Contains("."))
            {
                // 表示の数字を置き換える
                Result = n.ToString();
            }
            // 数字の長さが、10未満なら
            else if (Result.Length < 10)
            {
                // 表示の数字に追加する
                Result += n.ToString();
            }
        }

        // 「.」ボタン
        public void DotKey()
        {
            // 計算ボタンが押されていたら
            if (CmdKey == true)
            {
                // 0と小数点に置き換える
                Result = "0.";

                // 計算ボタンではないので
                CmdKey = false;
            }
            else
            {
                // 表示の数字に小数点が含まれてなく、数字の長さが10未満なら
                if (!Result.Contains(".") && Result.Length < 10)
                {
                    // 数字に小数点を付加する
                    Result += ".";
                }
            }
        }
    }
}
