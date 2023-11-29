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

        

        private void myCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            int z = 145;
            Answer.Text +=  $" {z} +" ;

        }

        private void myCheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            int x = 75;
            Answer.Text += $" {x} +";
        }
        private void myCheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            int c = 20;
            Answer.Text += $" {c} +";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            box1.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page6());
        }

        private void myCheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            int q = 20;
            Answer.Text += $" {q}" + "\n";
        }
        private void myCheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            int w = 45;
            Answer.Text += $" {w}" + "\n";
        }
    }
}
