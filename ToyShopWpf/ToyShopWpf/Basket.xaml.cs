using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToyShopWpf
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Page
    {
        public Basket()
        {
            InitializeComponent();
        }

        private void ButtonSum_Click(object sender, RoutedEventArgs e)
        {
            BasketInfo.Text = null;
            Summa.Text = null;
            DataTransfer.NameProduct = null;
            DataTransfer.SumProduct = null;
            DataTransfer.ProductSum = 0;
            Rub.Content = "";
            Itogo.Content = "";
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            BasketInfo.Text += DataTransfer.NameProduct;
            Summa.Text = DataTransfer.SumProduct;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
