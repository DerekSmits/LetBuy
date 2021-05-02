using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Models
{
    public class Book
    {
        public ushort price { set; get; }
        public int id { set; get; }
        public int categoryID { get; set; }
        public string img { set; get; }
        public string name { set; get; }
        public string longDesc { set; get; }
        public string shortDesc { set; get; }
        public string author { get; set; }
        public bool isAvailable { set; get; }
        public bool isFavourite { set; get; }
        public virtual Category category { set; get; }
    }
}
