using LetBuy.Interfaces;
using LetBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Mocks
{
    public class MockBooks : IBooks
    {
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>{
                new Book {name = "Mort", author = "Terry Pratchett", id = 0, img = "https://i2.wp.com/topspiski.com/wp-content/uploads/2018/03/4_thumb.jpg", price = 240, isFavourite = true},
                new Book {name = "Sound of thunder", author = "Ray Bradbury", id = 0, img = "https://images-na.ssl-images-amazon.com/images/I/81M1ZekATvL.jpg", price = 170, isFavourite = false}
            };
            }
        }
        public IEnumerable<Book> Fav { get; set; }
        public Book GetBook(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

