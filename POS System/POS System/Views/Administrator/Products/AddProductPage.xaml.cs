using POS_System.Models.Products;
using POS_System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POS_System.Views.Administrator.Products
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddProductPage : ContentPage
	{
		AddProductPageViewModel addProductPageViewModel;
		public AddProductPage ()
		{
			InitializeComponent ();
			this.BindingContext = new AddProductPageViewModel();
            addProductPageViewModel = new AddProductPageViewModel();
        }

        private async void btnAddProduct_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(txtImageURL.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                await DisplayAlert("Error", "Please complete the fields", "Ok");
            }
            else if (string.IsNullOrWhiteSpace(txtProductName.Text) && string.IsNullOrWhiteSpace(txtDescription.Text) &&
                string.IsNullOrWhiteSpace(txtPrice.Text) && string.IsNullOrWhiteSpace(txtImageURL.Text) &&
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                await DisplayAlert("Error", "No inputs detected", "Ok");
            }
            else
            {
                ProductsModel productsModel = new ProductsModel();
                productsModel.Name = txtProductName.Text;
                productsModel.Description = txtDescription.Text;
                productsModel.Price = double.Parse(txtPrice.Text);
                productsModel.ImageURL = txtImageURL.Text;
                productsModel.Category = txtCategory.Text;

                var isSaved = await addProductPageViewModel.AddProduct(productsModel);
                if (isSaved)
                {
                    await DisplayAlert("Notification", "Product added successfully.", "Ok");
                    Clear();

                }
                else
                {
                    await DisplayAlert("Error", "Can't add a product", "Ok");
                }
            }
        }

        public void Clear()
        {
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtImageURL.Text = string.Empty;
        }
    }
}