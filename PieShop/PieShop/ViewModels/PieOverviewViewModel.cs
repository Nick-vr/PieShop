using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PieShop.Models;

namespace PieShop.ViewModels
{
    internal class PieOverviewViewModel
    {
        public ObservableCollection<Pie> Pies { get; set; }

        public PieOverviewViewModel()
        {
            // Always init lists, even when empty
            Pies = new ObservableCollection<Pie>();
        }
    }
}