using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            books = db.Books.ToList();
            MainList.ItemsSource = books;
        }

        private void MainList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var track = ((ListView)sender).SelectedItem as Book;
            if (track != null)
            {
                basketBooks.Add(track);
            }
        }

        private void BasketButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new BasketPage());
        }
    }
}
