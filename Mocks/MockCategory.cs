using LetBuy.Interfaces;
using LetBuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetBuy.Mocks
{
    public class MockCategory
    {
        public IEnumerable<Category> AllCAtegories
        {
            get
            {
                return new List<Category>
                        {
                            new Category{ name = "For children", id = 0},
                            new Category{ name = "Fantasy", id = 1},
                            new Category{ name = "Horrors", id = 2}
                        };
            }
        }

    }
}
