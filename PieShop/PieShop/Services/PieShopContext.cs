using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PieShop.Models;
using Xamarin.Essentials;

namespace PieShop.Services
{
    public sealed class PieShopContext : DbContext
    {
        public DbSet<Gum> Gums { get; set; }
        public DbSet<Pie> Pies { get; set; }

        public PieShopContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = Path.Combine(FileSystem.AppDataDirectory, "PieShop.sqlite");
            optionsBuilder.UseSqlite($"Filename = {dbPath}");
        }
    }
}