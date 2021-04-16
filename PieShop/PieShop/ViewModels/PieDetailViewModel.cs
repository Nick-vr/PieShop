using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using PieShop.Models;
using PieShop.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PieShop.ViewModels
{
    [QueryProperty(nameof(PieId), nameof(PieId))]
    public class PieDetailViewModel : BaseViewModel
    {
        private Pie _selectedPie;

        public Pie SelectedPie
        {
            get => _selectedPie;
            set
            {
                _selectedPie = value;
                OnPropertyChanged(nameof(SelectedPie));
            }
        }

        private int _pieId;

        public int PieId
        {
            get => _pieId;
            set
            {
                _pieId = value;
                LoadPie(value);
            }
        }

        private IPieRepository _repository;

        public Command SaveCommand => new Command(OnSave);

        public PieDetailViewModel()
        {
            SelectedPie = new Pie();
            _repository = PieRepository.GetSingleton();
        }

        private void LoadPie(int value)
        {
            try
            {
                var pie = _repository.GetPie(value);
                SelectedPie = pie;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        private async void OnSave()
        {
            _repository.AddPie(SelectedPie);
            await Shell.Current.GoToAsync("..");
        }
    }
}