using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink()
                {
                    Id = 1,
                    Name = "Coffee",
                    Price = 6
                },
                  new Drink()
                {
                    Id = 2,
                    Name = "Tea",
                    Price = 3
                },

                  new Drink()
                {
                    Id = 3,
                    Name = "Cola",
                    Price = 2
                },
            };


            List<Food> food = new List<Food>
            {
                new Food()
                {
                    Id = 4,
                    Name = "Steak",
                    Price = 20
                },
                  new Food()
                {
                    Id = 5,
                    Name = "Pizza",
                    Price = 12
                },

                  new Food()
                {
                    Id = 6,
                    Name = "Kebab",
                    Price = 10
                },
            };


            List<Fastfood> fastfood = new List<Fastfood>
            {
                new Fastfood()
                {
                    Id = 7,
                    Name = "Burger",
                    Price = 7
                },
                  new Fastfood()
                {
                    Id = 8,
                    Name = "Chips",
                    Price = 4
                },

                  new Fastfood()
                {
                    Id = 9,
                    Name = "Ice-Cream",
                    Price = 3
                },
            };

            var vm = new MealListViewModel
            {
                Drinks = drinks,
                Foods = food,
                Fastfoods = fastfood

            };

            return View("AllMeals", vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink()
                {
                    Id = 1,
                    Name = "Coffee",
                    Price = 6
                },
                  new Drink()
                {
                    Id = 2,
                    Name = "Tea",
                    Price = 3
                },

                  new Drink()
                {
                    Id = 3,
                    Name = "Cola",
                    Price = 2
                },
            };

            return View("Drinks", drinks);
        }

        public IActionResult Food()
        {
            List<Food> food = new List<Food>
            {
                new Food()
                {
                    Id = 1,
                    Name = "Steak",
                    Price = 20
                },
                  new Food()
                {
                    Id = 2,
                    Name = "Pizza",
                    Price = 12
                },

                  new Food()
                {
                    Id = 3,
                    Name = "Kebab",
                    Price = 10
                },
            };

            return View("Food", food);
        }

        public IActionResult FastFood()
        {
            List<Fastfood> fastfood = new List<Fastfood>
            {
                new Fastfood()
                {
                    Id = 1,
                    Name = "Burger",
                    Price = 7
                },
                  new Fastfood()
                {
                    Id = 2,
                    Name = "Chips",
                    Price = 4
                },

                  new Fastfood()
                {
                    Id = 3,
                    Name = "Ice-Cream",
                    Price = 3
                },
            };

            return View("Fastfood", fastfood);
        }









    }
}

