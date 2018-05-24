using System;
using Microsoft.AspNetCore.Mvc;
using RESTaurant.Models;
using RESTaurant.Services.Interfaces.DataAccess;

namespace RESTaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var restaurants = _restaurantData.GetAll();
            return View(restaurants);
        }
    }
}
