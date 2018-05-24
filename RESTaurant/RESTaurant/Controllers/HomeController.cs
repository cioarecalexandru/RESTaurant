using System;
using Microsoft.AspNetCore.Mvc;
using RESTaurant.Models;

namespace RESTaurant.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var restaurant = new Restaurant() {ID = Guid.NewGuid(), Name = "Arkantos"};
            return View(restaurant);
        }
    }
}
