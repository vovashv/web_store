using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.Data.Interfaces;
using web_store.Data.Models;

namespace web_store.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                     {
                        new Category { CategoryName = "Tea", Description = "Non-alcoholic drinks" },
                         new Category { CategoryName = "Beer", Description = "Alcoholic drinks" },
                          new Category { CategoryName = "Coffy", Description = "Non-alcoholic drinks" },
                           new Category { CategoryName = "Dairy products", Description = "Non-alcoholic drinks" },
                            new Category { CategoryName = "Vodka", Description = "Alcoholic drinks" },
                             new Category { CategoryName = "Wine", Description = "Alcoholic drinks" },
                              new Category { CategoryName = "Cognac", Description = "Alcoholic drinks" },
                               new Category { CategoryName = "Mineral Water", Description = "Non-alcoholic drinks" }
                     };
            }
        }
    }
}
