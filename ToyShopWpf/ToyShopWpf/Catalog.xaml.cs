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

namespace ToyShopWpf
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Manager.MainFrame.GoBack();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }
    }
}
