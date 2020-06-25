using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.Data.Models;

namespace web_store.Data.Interfaces
{
    interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
