using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController (IAllCars allCars, ICarsCategory carsCategory)
        {
            _allCars = allCars;
            _allCategories = carsCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarListViewModel obj = new CarListViewModel();
            obj.AllCars = _allCars.Cars;
            obj.CurrCategory = "Автомобили";
            return View(obj);
        }
    }
}
