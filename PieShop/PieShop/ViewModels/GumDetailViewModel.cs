using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using PieShop.Models;
using PieShop.Services;
using Xamarin.Forms;

namespace PieShop.ViewModels
{
    [QueryProperty(nameof(GumId), nameof(GumId))]
    public class GumDetailViewModel : BaseViewModel
    {
        private Gum _selectedGum;

        public Gum SelectedGum
        {
            get => _selectedGum;
            set
            {
                _selectedGum = value;
                OnPropertyChanged(nameof(SelectedGum));
            }
        }

        private int _gumId;

        public int GumId
        {
            get => _gumId;
            set
            {
                _gumId = value;
                LoadPie(value);
            }
        }

        private readonly IGumRepository _repository;
        public Command SaveCommand => new Command(OnSave);

        public GumDetailViewModel()
        {
            SelectedGum = new Gum();
            _repository = new GumRepository();
        }

        private void LoadPie(int value)
        {
            try
            {
                var gum = _repository.GetGum(value);
                SelectedGum = gum;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        private async void OnSave(object obj)
        {
            _repository.SaveGum(SelectedGum);
            await Shell.Current.GoToAsync("..");
        }
    }
}