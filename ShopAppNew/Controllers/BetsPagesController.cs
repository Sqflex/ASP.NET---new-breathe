using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopAppNew.interfaces;
using ShopAppNew.ViewModels;

namespace ShopAppNew.Controllers
{
    [Authorize(Roles = "admin")]
    public class BetsPagesController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public BetsPagesController (IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
        }

        public ViewResult Navi()
        {
            ViewBag.Title = "1X BET";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allCars.Cars;
            obj.currCategory = "Киберспорт";
            return View(obj);
        }
    }
}
