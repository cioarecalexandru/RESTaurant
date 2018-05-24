using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTaurant.Models;

namespace RESTaurant.ViewModels
{
    public class HomeIndexViewModel
    {
        public string MessageOfDay { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
