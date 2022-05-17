﻿using RestApiCat.Model;
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
    public partial class CreateOrEditTodoPage : ContentPage
    {
        bool IsNewItem;
        public CreateOrEditTodoPage(bool isNew = false)
        {
            InitializeComponent();

            IsNewItem = isNew;
        }
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var todoItem = (EntryModel)BindingContext;
            await App.CountManager.SaveItemAsync(todoItem, IsNewItem);
            await Navigation.PopAsync();
        }
        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var todoItem = (EntryModel)BindingContext;
            await App.CountManager.DeleteTodoAsync(todoItem);
            await Navigation.PopAsync();
        }
    }
}