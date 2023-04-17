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
    }
}
