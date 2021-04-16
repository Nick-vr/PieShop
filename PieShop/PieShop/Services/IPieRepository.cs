using System.Collections.Generic;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.Services
{
    public interface IPieRepository
    {
        Task<List<Pie>> GetAllPiesAsync();

        Task<Pie> GetPieAsync(int id);

        Task SavePieAsync(Pie pie);
    }
}