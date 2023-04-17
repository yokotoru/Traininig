using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    internal class CurrentList
    {
        public static List<Book> books;
        public static DatabaseEpContext db = new DatabaseEpContext();
        public static decimal? priceTotal = 0;
        public static int discountTotal = 0;
    }
}
