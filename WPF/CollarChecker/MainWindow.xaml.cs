using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace CollarChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        //コンストラクタ
        public MainWindow() {
            InitializeComponent();

            DataContext = GetColorList(); //←追加

        }

        /// <summary>
        /// すべての色を取得するメソッド
        /// </summary>
        /// <returns></returns>
        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {

        }

        public void GetColor() {
            var g = gSlider.Value;
            var b = bSlider.Value;
            var r = rSlider.Value;
            colorArea.Background = new SolidColorBrush(Color.FromRgb((byte)r,(byte)g,(byte)b));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var mycolor = (MyColor)((ComboBox)sender).SelectedItem;
            //var color = mycolor.Color;
            //colorArea.Background = new SolidColorBrush(color);
            gSlider.Value = mycolor.Color.G;
            bSlider.Value = mycolor.Color.B;
            rSlider.Value = mycolor.Color.R;



        }
        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            GetColor();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

        }

        private void stockButton_Click(object sender, RoutedEventArgs e) {

        }
    }

    /// <summary>
    /// 色と色名を保持するクラス
    /// </summary>
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
