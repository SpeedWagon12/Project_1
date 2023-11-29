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

namespace project1
{
    /// <summary>
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            int a = 0;

        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            int b = 20;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            int c = 45;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            int z = 145;
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            int x = 75;
        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            int c = 20;
        }

        private void myCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            int z = 145;
           
        }
private void Button_Click(object sender, RoutedEventArgs e)
        {
            box1.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page6());
        }
    }
}
