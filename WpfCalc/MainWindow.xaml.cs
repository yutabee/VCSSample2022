using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ViewModelオブジェクトの生成
        readonly CalcViewModel ViewModel = new();

        public MainWindow()
        {
            InitializeComponent();

            // データ元の設定
            DataContext = this.ViewModel;
        }

        private void Num_Click(object sender, RoutedEventArgs e)
        {
            // 各ボタンのインスタンスを取得
            var btn = (Button)sender;
            this.ViewModel.NumCommand(btn.Content);
        }

        private void Cmd_Click(object sender, RoutedEventArgs e)
        {
            // 各ボタンのインスタンスを取得
            var btn = (Button)sender;
            this.ViewModel.CmdCommand(btn.Content);
        }
    }
}
