using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using PieShop.Models;
using PieShop.Services;
using PieShop.Views;
using Xamarin.Forms;

namespace PieShop.ViewModels
{
    public class GumsViewModel : BaseViewModel
    {
        private ObservableCollection<Gum> _gums;

        public ObservableCollection<Gum> Gums
        {
            get => _gums;
            set
            {
                _gums = value;
                OnPropertyChanged(nameof(Gums));
            }
        }

        private IGumRepository _repository;
        public Command AddGumPageCommand => new Command(AddGumPage);
        public Command LoadGumsCommand => new Command(LoadGums);
        public Command<Gum> ItemTapped => new Command<Gum>(OnGumSelected);

        public GumsViewModel()
        {
            _repository = new GumRepository();
            LoadGums();
        }

        public async void AddGumPage()
        {
            await Shell.Current.GoToAsync($"{nameof(GumDetailPage)}");
        }

        public void LoadGums()
        {
            IsBusy = true;

            try
            {
                var gums = _repository.GetAllGums();
                Gums = new ObservableCollection<Gum>(gums);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async void OnGumSelected(Gum gum)
        {
            await Shell.Current.GoToAsync($"{nameof(GumDetailPage)}?{nameof(GumDetailViewModel.GumId)}={gum.Id}");
        }
    }
}