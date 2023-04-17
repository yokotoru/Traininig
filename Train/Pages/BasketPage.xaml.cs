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

namespace Train.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
        public BasketPage()
        {
            InitializeComponent();
            MainList.ItemsSource = basketBooks;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.GoBack();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            basketBooks.Clear();
            MainList.ItemsSource = basketBooks;
        }
    }
}
