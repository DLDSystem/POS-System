using POS_System.Models.Products;
using POS_System.ViewModels;
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
	public partial class BreakfastPage : ContentPage
	{
		AddProductPageViewModel addProductPageViewModel = new AddProductPageViewModel();
        public BreakfastPage ()
		{
			InitializeComponent();
        }

		protected override async void OnAppearing()
		{
            var products = await addProductPageViewModel.GetProducts();
            BreakfastPageView.ItemsSource = products;
        }
	}
}