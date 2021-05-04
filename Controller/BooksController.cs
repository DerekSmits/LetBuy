using LetBuy.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Controller
{
    public class BooksController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IBooks _AllBooks;
        private  ICategories _AllCat;
        public  BooksController(IBooks AllBooks, ICategories AllCat)
        {
            _AllBooks = AllBooks;
            _AllCat = AllCat;
        }
        public ViewResult List()
        {
            return View();
        }
    }
}
