using PieShop.ViewModels;
using PieShop.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PieShop
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(PieDetailView), typeof(PieDetailView));
            Routing.RegisterRoute(nameof(GumDetailPage), typeof(GumDetailPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}