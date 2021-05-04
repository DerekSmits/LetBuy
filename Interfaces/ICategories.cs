using LetBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Interfaces
{
    public interface ICategories
    {
        public IEnumerable<Category> Categories { get; }
    }
}
