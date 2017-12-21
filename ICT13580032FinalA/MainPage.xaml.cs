using System;
using System.Collections.Generic;
using ICT13580032FinalA.Models;
using Xamarin.Forms;

namespace ICT13580032FinalA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            newButton.Clicked += NewButton_Clicked;
        }

        protected override void OnAppearing()
        {
            LoadData();
        }

        void LoadData()
        {
            statusListView.ItemsSource = App.DbHelper.GetStatus();
        }

        void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StatusNewPage());
        }

        void Edit_Clicked(object sender, System.EventArgs e)
        {
            var button = sender as MenuItem;
            var status = button.CommandParameter as Status;
            Navigation.PushModalAsync(new StatusNewPage(status));
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
			
        }
    }
}
