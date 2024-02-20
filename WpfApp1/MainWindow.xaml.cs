using System.Text;
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
        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        { 
            if(string.IsNullOrEmpty(TbY.Text) || string.IsNullOrEmpty(TbX.Text))
            {
                MessageBox.Show($"ERROR",
                        "Задание №14",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
            }
            else
            {
                double x = Convert.ToDouble(TbX.Text),y = Convert.ToDouble(TbY.Text);
                MessageBox.Show($"R = {Math.Round(Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y),2)+6.83335))+Math.Exp(x),2)}",    
                                "Задание №14",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                TbX.Text = string.Empty;
                TbY.Text = string.Empty;
            }
     
        }
    }
}