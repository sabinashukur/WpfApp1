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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var random1 = Convert.ToByte(Random.Shared.Next(0, 255));
            var random2 = Convert.ToByte(Random.Shared.Next(0, 255));
            var random3 = Convert.ToByte(Random.Shared.Next(0, 255));
            btn.Background = new SolidColorBrush(Color.FromRgb(random1, random2, random3));
            MessageBox.Show($"My Color: {btn.Background}, My Content: {btn.Content}");

        }

        private void Button_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            var btn = sender as Button;
            btn.Visibility = Visibility.Collapsed;
            Title = btn.Content.ToString();

        }
    }
}
