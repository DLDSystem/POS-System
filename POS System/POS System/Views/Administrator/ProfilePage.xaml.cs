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
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			InitializeComponent ();
		}

        private async void btnLogout_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Confirmation","Are you sure you want to logout?", "Yes","No");

            if (result)
            {
                await Navigation.PushAsync(new LoginPage());
            }    

        }
    }
}