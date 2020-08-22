using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.Data.Interfaces;
using web_store.Data.Models;

namespace web_store.Data.Repositories
{
    public class CategoryRepository :ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
