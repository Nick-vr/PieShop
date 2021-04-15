using System;
using System.Collections.Generic;
using System.Text;

namespace PieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private double _price;

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        private string _description;

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        private bool _isInStock;

        public bool IsInStock
        {
            get => _isInStock;
            set => _isInStock = value;
        }

        private string _imageUrl;

        public string ImageUrl
        {
            get => _imageUrl ?? (_imageUrl = "cheesecakesmall.jpg");
            set => _imageUrl = value;
        }
    }
}