using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class CurrentList
    {
        public static List<Book> books; // создание основного списка книг
        public static DatabaseEpContext db = new DatabaseEpContext(); // инициализация класса вызова бд
        public static decimal? priceTotal = 0; // итоговая цена корзины
        public static int discountTotal = 0; // итоговая скидка
    }
}
