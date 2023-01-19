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

        private void CarCheck_Checked(object sender, RoutedEventArgs e)
        {

            DataTransfer.ProductSum += 100;
            basketCar.Text = "Машинка 100руб.";
            DataTransfer.NameProduct += "\n" + basketCar.Text;
            DataTransfer.SumProduct = Convert.ToString(DataTransfer.ProductSum);
        
        }

        private void CarCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            
            basketCar.Text = "";
          
        }

        private void CarDoll_Checked(object sender, RoutedEventArgs e)
        {
            DataTransfer.ProductSum += 100;
            basketDoll.Text = "Кукла 100руб.";
            DataTransfer.NameProduct += "\n" + basketDoll.Text;
            DataTransfer.SumProduct = Convert.ToString(DataTransfer.ProductSum);
        }

        private void CarDoll_Unchecked(object sender, RoutedEventArgs e)
        {
          
            basketDoll.Text = "";
        }

        private void CarPuzle_Checked(object sender, RoutedEventArgs e)
        {

            DataTransfer.ProductSum += 100;
            basketPuzle.Text = "Пазл 100руб.";
            DataTransfer.NameProduct += "\n" + basketPuzle.Text;
            DataTransfer.SumProduct = Convert.ToString(DataTransfer.ProductSum );
        }

        private void CarPuzle_Unchecked(object sender, RoutedEventArgs e)
        {

           
            basketPuzle.Text = "";
        }
    }
}
