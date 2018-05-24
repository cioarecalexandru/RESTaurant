using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTaurant.Models;

namespace RESTaurant.Services.Interfaces.DataAccess
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
