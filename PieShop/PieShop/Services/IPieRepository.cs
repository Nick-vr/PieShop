using System;
using System.Collections.Generic;
using System.Text;
using PieShop.Models;

namespace PieShop.Services
{
    public interface IPieRepository
    {
        List<Pie> GetAllPies();

        void AddPie(Pie pie);
    }
}