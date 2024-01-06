using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace POS_System.Models.Products
{
    public class ProductsModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public  string ImageURL { get; set; }
        public string Category { get; set; }

    }
}
