using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PieShop.Models;

namespace PieShop.Services
{
    public class GumRepository : IGumRepository
    {
        // Singleton
        private static GumRepository _instance;

        private GumRepository()
        {
            AddDummyData();
        }

        public static GumRepository GetSingleton() => _instance ?? (_instance = new GumRepository());

        // MOCK DB
        private List<Gum> _gums { get; set; }

        public List<Gum> GetAllGums() => _gums;

        public void AddGum(Gum gum) => _gums.Add(gum);

        private void AddDummyData()
        {
            _gums = new List<Gum>
            {
                new Gum
                {
                    Id = 1,
                    IsInStock = true,
                    ImageUrl = "mentos_bubble.png",
                    Name = "Bubble Gum",
                    Price = 3.95,
                    Description = "MENTOS GUM PURE FRESH CINNAMON CURVY BOTTLE"
                },
                new Gum
                {
                    Id = 2,
                    IsInStock = true,
                    ImageUrl = "mentos_cinnamon.png",
                    Name = "Cinnamon Gum",
                    Price = 3.95,
                    Description = "MENTOS GUM PURE FRESH CINNAMON CURVY BOTTLE"
                },
                new Gum
                {
                    Id = 3,
                    IsInStock = true,
                    ImageUrl = "mentos_grape.png",
                    Name = "Grape Gum",
                    Price = 3.95,
                    Description = "MENTOS GUM PURE FRESH GRAPE MEDLEY"
                },
                new Gum
                {
                    Id = 4,
                    IsInStock = true,
                    ImageUrl = "mentos_watermelon.png",
                    Name = "Watermelon Gum",
                    Price = 3.95,
                    Description = "MENTOS GUM WATERMELON CURVY BOTTLE"
                },
            };
        }

        public Gum GetGum(int id) => _gums.FirstOrDefault(x => x.Id == id);
    }
}