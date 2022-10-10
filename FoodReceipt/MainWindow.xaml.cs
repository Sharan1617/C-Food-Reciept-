//Author: Group 9 Arman Merchant 8821749,Sharanveer Singh Mehta 8746201,LakshmiPriya Hari 8833696,Zhuoying Yang 8797724,Pavan Katuku 8750181
using System.Windows;
using System.Windows.Media;

namespace FoodReceipt
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

        private void CalculateResult_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal firstInputDec = decimal.Parse(InputText.Text);

                decimal calTips = (firstInputDec) * 0.15m;  //in actual 0.15 is a double so have to convert it into decimal using "m or like in line 26"
                TipsLabel.Content = calTips.ToString("C");

                decimal calTax = (firstInputDec) * (decimal)0.07;
                SaleOutput.Content = calTax.ToString("C");

                decimal TotalOutput = firstInputDec + calTips + calTax;
                LabelTotal.Content = TotalOutput;

                TipsLabel.Background = new SolidColorBrush(Colors.Chocolate);
                SaleOutput.Background = new SolidColorBrush(Colors.Crimson);
                LabelTotal.Background = new SolidColorBrush(Colors.Gold);

                TipsLabel.Visibility = Visibility.Visible;
                SaleOutput.Visibility = Visibility.Visible;
                LabelTotal.Visibility = Visibility.Visible;
            }
            catch
            {
                MessageBox.Show("Enter Valid Numbers");
                InputText.Text = "";
            }
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            InputText.Text = "";
            TipsLabel.Visibility = Visibility.Hidden;
            SaleOutput.Visibility = Visibility.Hidden;
            LabelTotal.Visibility = Visibility.Hidden;
        }
    }
}
