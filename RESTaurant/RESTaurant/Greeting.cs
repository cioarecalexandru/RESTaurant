using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RESTaurant.Interfaces.Greeting;

namespace RESTaurant
{
    public class Greeting : IGreeting
    {
        private readonly IConfiguration _configuration;

        public Greeting(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageOfTheDay()
        {
            return _configuration["Salutare"];
        }
    }
}
