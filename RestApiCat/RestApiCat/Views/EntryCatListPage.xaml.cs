using RestApiCat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestApiCat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]   
    public partial class EntryCatListPage : ContentPage
    {
        public EntryCatListPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.CountManager.GetTasksAsync();
        }
        private void TodoLV_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Navigation.PushAsync(new CreateOrEditTodoPage()
            {
                BindingContext = e.SelectedItem as EntryModel
            });
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateOrEditTodoPage(true)
            {
                BindingContext = new EntryModel()
                {
                    id = Guid.NewGuid().ToString(),
                }
            });
        }
    }
}