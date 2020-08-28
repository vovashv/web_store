using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web_store.Controllers
{
    public class ContactController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
