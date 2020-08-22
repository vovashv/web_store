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
                        new Category { CategoryName = "Alcoholic drinks", Description = "Alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic drinks", Description = "Non-alcoholic drinks" }
                };
            }
        }
    }
}
