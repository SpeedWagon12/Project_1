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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string m = box1.Text;
            string b = box2.Text;
            string q = box3.Text;
            string w = box4.Text;
            string h = box5.Text;
            string r = box6.Text;
            string t = box7.Text;
            string y = box8.Text;
            this.NavigationService.Navigate(new Page5());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            box1.Clear();
            box2.Clear();
            box3.Clear();
            box4.Clear();
            box5.Clear();
            box7.Clear();
            box8.Clear();
        }
    }
}
