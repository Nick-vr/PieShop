using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PieShop.Models;
using PieShop.Services;
using PieShop.Views;
using Xamarin.Forms;

namespace PieShop.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged(nameof(Pies));
            }
        }

        private IPieRepository _repository;
        public Command GoToAddPiePageCommand => new Command(GoToAddPiePage);
        public Command LoadPiesCommand => new Command(LoadPies);

        public PieOverviewViewModel()
        {
            _repository = PieRepository.GetSingleton();
            LoadPies();
        }

        public async void GoToAddPiePage()
        {
            await Shell.Current.GoToAsync($"{nameof(PieDetailView)}");
        }

        public void LoadPies()
        {
            var pies = _repository.GetAllPies();
            Pies = new ObservableCollection<Pie>(pies);
        }
    }
}