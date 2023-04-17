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
            books = db.Books.ToList(); // получение данных из бд в основной лист
            MainList.ItemsSource = books; // приравнивание содержимого ListView к основному листу с книгами
            CountOfSelected.Text = (basketBooks.Count).ToString(); // количество книг в корзине
            Price.Text = priceTotal.ToString(); // итоговая цена корзины
        }

        private void BasketButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new BasketPage());
        }
        decimal? help;
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            Book result = (sender as Button)?.DataContext as Book; // получение объекта, который нужно добавить
            basketBooks.Add(result); // добавляем элемент в лист корзины
            // ниже не доделано
            int count = 0;
            CountOfSelected.Text = (basketBooks.Count).ToString();
            priceTotal += result.Price;
            help = priceTotal;
            while (help > 0)
            {
                help -= 500;
                discountTotal += 1;
            }
            discountTotal -= 1;
            if (basketBooks.Count >= 3 && basketBooks.Count < 5)
            {
                discountTotal += 5;
                
            }
            Price.Text = priceTotal.ToString();
            Discount.Text = discountTotal.ToString();
        }
    }
}
