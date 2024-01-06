using POS_System.Views.Administrator.Products;
using POS_System.Views.Administrator.Products.ProductsTabbed;
using POS_System.Views.Administrator.ProductsTabbed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POS_System.Views.Administrator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductsPage : ContentPage
	{
		public ProductsPage ()
		{
			InitializeComponent ();

            //Initially load the first page
            LoadPage(new BreakfastPage());
		}

        private void btnBreakfast_Clicked(object sender, EventArgs e)
        {
            LoadPage(new BreakfastPage());
        }

        private void btnBurgers_Clicked(object sender, EventArgs e)
        {
            LoadPage(new BurgersPage());
        }

        private void LoadPage(ContentPage page)
        {
            contentContainer.Content = page.Content;
        }

        private void btnChickenPlatters_Clicked(object sender, EventArgs e)
        {
            LoadPage(new ChickenPlattersPage());
        }

        private void btnDrinksDesserts_Clicked(object sender, EventArgs e)
        {
            LoadPage(new DrinksDessertsPage());
        }

        private void btnMcCafé_Clicked(object sender, EventArgs e)
        {
            LoadPage(new McCaféPage());
        }

        private void btnFries_Clicked(object sender, EventArgs e)
        {
            LoadPage(new FriesPage());
        }

        private void btnDisplayAddProductUI_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddProductPage());
        }
    }
}