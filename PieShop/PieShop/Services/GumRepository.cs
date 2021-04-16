using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PieShop.Models;

namespace PieShop.Services
{
    public class GumRepository : IGumRepository
    {
        public List<Gum> GetAllGums()
        {
            using (var dbContext = new PieShopContext())
            {
                return dbContext.Gums.ToList();
            }
        }

        public Gum GetGum(int id)
        {
            using (var dbContext = new PieShopContext())
            {
                return dbContext.Gums.Find(id);
            }
        }

        public void SaveGum(Gum gum)
        {
            using (var dbContext = new PieShopContext())
            {
                if (gum.Id == 0)
                {
                    dbContext.Gums.Add(gum);
                }
                else
                {
                    dbContext.Gums.Update(gum);
                }

                dbContext.SaveChanges();
            }
        }
    }
}