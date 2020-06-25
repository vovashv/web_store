﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.Data.Interfaces;

namespace web_store.Controllers
{

    public class DrinkController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DrinkController(IDrinkRepository drinkRepository, ICategoryRepository categoryRepository)
        {
            _drinkRepository = drinkRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View(drinks);


        }
    }

}
