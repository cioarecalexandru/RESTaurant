using Microsoft.AspNetCore.Mvc;

namespace RESTaurant.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from the HomeController";
        }
    }
}
