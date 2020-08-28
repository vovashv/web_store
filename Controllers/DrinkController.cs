using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.Data.Interfaces;
using web_store.Data.Models;
using web_store.ViewModels;

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

        public ViewResult List(string category)
        {
            //var drinks = _drinkRepository.Drinks;

            //DrinkListViewModel vm = new DrinkListViewModel();
            //vm.Drinks = _drinkRepository.Drinks;
            //vm.CurrentCategory = "DrinkCategory";

            //return View(vm);

            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic",_category,StringComparison.OrdinalIgnoreCase))
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p=>p.Name);
                }
                else
                {
                    drinks = _drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);
                }
                currentCategory = _category;
            }
            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
            return View(drinkListViewModel);
        }
    }

}
