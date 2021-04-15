using PieShop.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PieShop.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}