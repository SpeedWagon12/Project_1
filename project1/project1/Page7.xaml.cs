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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page5());
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы еще не участвовали в марафоннах");
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
