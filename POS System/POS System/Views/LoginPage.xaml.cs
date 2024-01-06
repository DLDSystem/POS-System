using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POS_System.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEmail.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                await DisplayAlert("Error","No inputs detected", "OK");    
            }
            else if(string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                await DisplayAlert("Error", "Please input the fields completely", "OK");
            }
            else if( txtEmail.Text == "daldedaniellus@gmail.com" && txtPassword.Text == "daniel")
            {
                await Navigation.PushAsync(new TabbedContainer());
            }
            else
            {
                await DisplayAlert("Error", "Username or password incorrect", "OK");
            }
        }

        private async void btnSignup_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignupPage());
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.IsEnabled = false;
            }
            else
            {
                btnLogin.IsEnabled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                btnLogin.IsEnabled = false;
            }
            else
            {
                btnLogin.IsEnabled = true;
            }
        }
    }
}