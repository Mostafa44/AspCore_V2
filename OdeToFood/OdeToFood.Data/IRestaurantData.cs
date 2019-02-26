using OdeToFoode.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
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

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants;
        }
    }
}