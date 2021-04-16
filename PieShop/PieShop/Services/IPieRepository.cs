using System.Collections.Generic;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.Services
{
    public interface IPieRepository
    {
        Task<List<Pie>> GetAllPies();

        Task<Pie> GetPie(int id);

        Task SavePie(Pie pie);
    }
}