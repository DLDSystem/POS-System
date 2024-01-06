using Firebase.Database;
using Firebase.Database.Query;
using POS_System.Models;
using POS_System.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace POS_System.ViewModels
{
    public class AddProductPageViewModel
    {
        FirebaseClient firebase = new FirebaseClient(Setting.FirebaseDatabaseURL);

        public async Task<bool> AddProduct(ProductsModel products)
        {
            var data = await firebase.Child(nameof(ProductsModel)).PostAsync(products);

            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<ProductsModel>> GetProducts()
        {
            return (await firebase.Child(nameof(ProductsModel)).OnceAsync<ProductsModel>()).Select(item => new ProductsModel
            {
                Name = item.Object.Name,
                Price = item.Object.Price,
                Description = item.Object.Description,
                ImageURL = item.Object.ImageURL,
                Category = item.Object.Category
            }).ToList();
        }
    }
}
