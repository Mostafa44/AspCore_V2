using System;

namespace OdeToFoode.Core
{
    public enum CuisinType
    {
        None,
        Mexian,
        Italian,
        Indian
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public CuisinType Cuisine { get; set; }
    }
}