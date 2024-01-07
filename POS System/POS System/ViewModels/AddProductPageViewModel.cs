using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using POS_System.Models;
using POS_System.Models.Products;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            var data = await firebase.Child("ProductsModel").PostAsync(JsonConvert.SerializeObject(products));

            if (!string.IsNullOrEmpty(data.Key))
            {
                return true;
            }
            return false;
        }
    }
}
