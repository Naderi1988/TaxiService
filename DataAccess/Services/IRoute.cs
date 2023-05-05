using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Route;

namespace DataAccess.Services
{
   interface IRoute
    {
        int RegisterRoute(Route NRout);
        bool Remove(int IdRoute);
        bool Update(Route NRoute);
        List<Route> GetAllRoute();
        Route Get(int IdRoute);
        List<Route> Search(RouteSearchModel sm);
       
    }
}
