using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Cartex;

namespace DataAccess.Services
{
    interface ICartex
    {
        int RegisterCartex(Cartex NCartex);
        bool Remove(int IdCartex);
        bool Update(Cartex NewCartex);
        Cartex Get(int IdCartex);
        List<Cartex> GetAllCartex();
               List<CartexFulInformation> GetCartexList();
    }
}
