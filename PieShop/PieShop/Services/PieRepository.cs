using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PieShop.Models;
using Xamarin.Forms;

namespace PieShop.Services
{
    public class PieRepository : IPieRepository
    {
        public async Task<List<Pie>> GetAllPies()
        {
            using (var dbContext = new PieShopContext())
            {
                return await dbContext.Pies.ToListAsync();
            }
        }

        public async Task<Pie> GetPie(int id)
        {
            using (var dbContext = new PieShopContext())
            {
                return await dbContext.Pies.FindAsync(id);
            }
        }

        //private void AddDummyData()
        //{
        //    _pies = new List<Pie>
        //    {
        //        new Pie
        //        {
        //            Id = 1,
        //            IsInStock = true,
        //            ImageUrl = "strawberrypiesmall.jpg",
        //            Name = "Strawberry Pie",
        //            Price = 15.95,
        //            Description =
        //                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies."
        //        },
        //        new Pie
        //        {
        //            Id = 2,
        //            IsInStock = true,
        //            ImageUrl = "cheesecakesmall.jpg",
        //            Name = "Cheese cake",
        //            Price = 18.95,
        //            Description =
        //                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies."
        //        },
        //        new Pie
        //        {
        //            Id = 3,
        //            IsInStock = true,
        //            ImageUrl = "rhubarbpiesmall.jpg",
        //            Name = "Rhubarb Pie",
        //            Price = 15.95,
        //            Description =
        //                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies."
        //        },
        //        new Pie
        //        {
        //            Id = 4,
        //            IsInStock = true,
        //            ImageUrl = "pumpkinpiesmall.jpg",
        //            Name = "Pumpkin Pie",
        //            Price = 12.95,
        //            Description =
        //                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies."
        //        }
        //    };
        //}

        public async Task SavePie(Pie pie)
        {
            using (var dbContext = new PieShopContext())
            {
                if (pie.Id == 0)
                {
                    await dbContext.Pies.AddAsync(pie);
                }
                else
                {
                    dbContext.Pies.Update(pie);
                }

                await dbContext.SaveChangesAsync();
            }
        }
    }
}