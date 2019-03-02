using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;
using OdeToFoode.Core;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        private IRestaurantData _restaurantData;

        public Restaurant Restaurant { get; set; }

        public DetailModel(IRestaurantData restauranatData)
        {
            _restaurantData = restauranatData;
        }

        public IActionResult OnGet(int restaurnatId)
        {
            Restaurant = _restaurantData.GetById(restaurnatId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}