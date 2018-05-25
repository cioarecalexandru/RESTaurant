using System;
using Microsoft.AspNetCore.Mvc;
using RESTaurant.Interfaces.Greeting;
using RESTaurant.Models;
using RESTaurant.Services.Interfaces.DataAccess;
using RESTaurant.ViewModels;

namespace RESTaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IGreeting _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeting greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var modelView = new HomeIndexViewModel()
            {
                MessageOfDay = _greeter.GetMessageOfTheDay(),
                Restaurants = _restaurantData.GetAll()
            };
            return View(modelView);
        }

        public IActionResult Details(int index)
        {
            Restaurant model = _restaurantData.Get(index);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
