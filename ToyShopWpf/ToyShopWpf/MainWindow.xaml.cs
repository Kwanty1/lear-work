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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        string login = "admin";
        string password = "admin";
        string login1 = "user";
        string password1 = "user";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Log= LoginBox.Text;
            string Pass= PassBox.Password;
            if( Log==login && Pass==password  )
            {
                Menu profileWindow = new Menu();
                profileWindow.Show();
                this.Close();
            }
            else
            {
                if ( Log==login1 && Pass==password1 )
                {
                    Menu profileWindow = new Menu();
                    profileWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Данные неверны", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }

       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция в разработке", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void LookPass_Checked(object sender, RoutedEventArgs e)
        {
            PassBox1.Text = PassBox.Password;
            PassBox.Visibility = Visibility.Collapsed;
            PassBox1.Visibility = Visibility.Visible;
        }

        private void LookPass_Unchecked(object sender, RoutedEventArgs e)
        {
            PassBox.Password = PassBox1.Text;
            PassBox1.Visibility = Visibility.Collapsed;
            PassBox.Visibility = Visibility.Visible;
        }
    }
}
