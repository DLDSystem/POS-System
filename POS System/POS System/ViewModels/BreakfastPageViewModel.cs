using Firebase.Database;
using POS_System.Models;
using POS_System.Models.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace POS_System.ViewModels
{
    public class BreakfastPageViewModel
    {
        FirebaseClient firebase = new FirebaseClient(Setting.FirebaseDatabaseURL);

        private ObservableCollection<ProductsModel> _products;

        public ObservableCollection<ProductsModel> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public BreakfastPageViewModel()
        {
            Products = new ObservableCollection<ProductsModel>();

            GetBreakfastProducts();
        }

        private async Task GetBreakfastProducts()
        {
            var products = await firebase.Child("ProductsModel").OnceAsync<ProductsModel>();

            foreach (var product in products)
            {
                Products.Add(product.Object);
            }
        }
    }

}
