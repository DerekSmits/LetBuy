using LetBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Interfaces
{
    interface IBooks
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Book> Fav { get; }
        Book getBook(int bookID);
    }
}
