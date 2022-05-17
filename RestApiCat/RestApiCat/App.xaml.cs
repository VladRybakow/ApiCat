using RestApiCat.Services;
using RestApiCat.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApiCat
{
    public partial class App : Application
    {
        public static EntryManager CountManager { get; set; }
        public App()
        {
            InitializeComponent();

            CountManager = new EntryManager(new RestService());
            MainPage = new NavigationPage(new EntryCatListPage());
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
