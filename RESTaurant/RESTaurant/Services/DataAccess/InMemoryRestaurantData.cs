using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTaurant.Models;
using RESTaurant.Services.Interfaces.DataAccess;

namespace RESTaurant.Services.DataAccess
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    ID = Guid.NewGuid(),
                    Name = "Arkantos"
                },
                new Restaurant()
                {
                    ID= Guid.NewGuid(),
                    Name = "Ardelenesc"
                },
                new Restaurant()
                {
                    ID = Guid.NewGuid(),
                    Name = "Pizza de Fitze"
                }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int index)
        {
            if (index > _restaurants.Count)
            {
                return null;
            }
            return _restaurants[index];
        }
    }
}
