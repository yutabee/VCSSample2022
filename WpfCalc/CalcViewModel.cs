using System.ComponentModel;

namespace WpfCalc
{
    abstract class ViewModelBase : INotifyPropertyChanged
    {
        // プロパティの変更通知
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(name));
        }
    }

    internal class CalcViewModel : ViewModelBase
    {
        // 電卓クラスのインスタンス化
        readonly ClassCalc Calc = new();
        
        // 計算結果のプロパティ
        public string Label { get; private set; } = "0";

        // 数字ボタンが押されたときの処理
        public void NumCommand(object content)
        {
            // ボタン名を数値に変換
            var n = int.Parse((string)content);
            
            // 電卓クラスの数字ボタン処理を呼び出す
            Calc.NumKey(n);
            
            // 計算結果の設定
            Label = Calc.Result;

            // 更新を通知する
            OnPropertyChanged(nameof(Label));
        }

        // 演算ボタンのイベントハンドラ
        public void CmdCommand(object content)
        {
            switch ((string)content)
            {
                case "C":
                    // 初期化処理
                    Calc.ClrKey();
                    break;

                case ".":
                    Calc.DotKey();
                    break;

                case "/":
                    Calc.DivisionKey();
                    break;

                case "*":
                    Calc.MultiKey();
                    break;

                case "+":
                    Calc.PlusKey();
                    break;

                case "-":
                    Calc.MinusKey();
                    break;

                case "=":
                    Calc.EnterKey();
                    break;
            }

            // 計算結果の設定
            Label = Calc.Result;
            OnPropertyChanged(nameof(Label));
        }
    }
}
