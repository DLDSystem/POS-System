using POS_System.Services.Implementation;
using POS_System.Views;
using POS_System.Views.Administrator;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POS_System
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GreetingsPage()); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
