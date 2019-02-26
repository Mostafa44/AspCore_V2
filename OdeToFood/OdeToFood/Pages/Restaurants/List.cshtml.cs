using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFoode.Core;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private IConfiguration _config;
        private IRestaurantData _restuarantData;
        public IEnumerable<Restaurant> restaurants;

        public string Message { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restauranatData)
        {
            _config = config;
            _restuarantData = restauranatData;
            restaurants = new List<Restaurant>();
        }

        public void OnGet()
        {
            //  Message = "Hello From ListModel";
            Message = _config["Message"];
            restaurants = _restuarantData.GetAll();
        }
    }
}