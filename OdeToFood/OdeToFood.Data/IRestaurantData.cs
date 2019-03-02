using OdeToFoode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantByName(string name);

        Restaurant GetById(int id);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant(){Id=1, Name="Scott's Pizza", Location="LA", Cuisine=CuisinType.Italian},
                new Restaurant(){Id=2, Name="Mahraja", Location="Cairo", Cuisine=CuisinType.Indian},
                new Restaurant(){Id=3, Name="Mex Tex", Location="CAL", Cuisine=CuisinType.Mexian},
                new Restaurant(){Id=4, Name="Vittorio", Location="Maryland", Cuisine=CuisinType.Italian},
            };
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name = null)
        {
            return from r in _restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }

        public Restaurant GetById(int id)
        {
            return _restaurants.SingleOrDefault(r => r.Id == id);
        }
    }
}