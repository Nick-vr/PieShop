using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using PieShop.Models;
using PieShop.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PieShop.ViewModels
{
    public class PieDetailViewModel : BaseViewModel
    {
        public Pie SelectedPie { get; set; }

        private IPieRepository _repository;

        public ICommand SaveCommand => new Command(OnSave);

        public PieDetailViewModel()
        {
            SelectedPie = new Pie();
            _repository = PieRepository.GetSingleton();
        }

        private async void OnSave()
        {
            _repository.AddPie(SelectedPie);
            await Shell.Current.GoToAsync("..");
        }
    }
}