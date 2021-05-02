using LetBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Interfaces
{
    interface IBooks
    {
        public IEnumerable<Book> Books { get; }
        public IEnumerable<Book> Fav { get; }
        Book GetBook(int bookID);
    }
}
