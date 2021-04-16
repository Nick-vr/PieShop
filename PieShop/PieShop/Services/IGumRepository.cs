using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.Services
{
    public interface IGumRepository
    {
        List<Gum> GetAllGums();

        void SaveGum(Gum gum);

        Gum GetGum(int id);
    }
}