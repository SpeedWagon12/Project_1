﻿using System;
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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Runner_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page2());
        }

        private void Sponsor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Informatoin_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Page3());
        }
    }
}
