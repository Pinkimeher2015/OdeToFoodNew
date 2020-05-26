using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurants> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurants>()
            {
                new Restaurants{Id=1, Name="KFC Chicken" , Couisine = coisine_type.French},
                new Restaurants{Id=1, Name="Burgers" , Couisine = coisine_type.Indian},
                new Restaurants{Id=1, Name="Hakka Noodles" , Couisine = coisine_type.Chinese},
            };
        }
        IEnumerable<Restaurants> IRestaurantData.GetAll()
        {
            return restaurants.OrderBy(p => p.Name);
           
        }
    }
}
