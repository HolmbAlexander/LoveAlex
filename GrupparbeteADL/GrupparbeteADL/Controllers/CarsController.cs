using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrupparbeteADL.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrupparbeteADL.Controllers
{
    public class CarsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var models = DataManager.ListCars();
            return View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsCreateVM viewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(viewModel);
            }
            DataManager.AddCar(viewModel);
            return RedirectToAction(nameof(CarsController.Index));
        }
    }
}
