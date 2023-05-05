using DataAccess.Services;
using DomainModel.ViewModel.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Trip;

namespace DataAccess.Repositories
{
    public class RouteRepository : IDisposable, IRoute
    {
        Model4 db = new Model4();
        public void Dispose()
        {
            this.db.Dispose();
        }

        public DomainModel.Model.Route Get(int IdRoute)
        {
            var route = db.Routes.FirstOrDefault(x => x.RouteID == IdRoute);
            return route;
        }

        public List<DomainModel.Model.Route> GetAllRoute()
        {
            return db.Routes.ToList();
        }



        public int RegisterRoute(DomainModel.Model.Route NRout)
        {
            db.Routes.Add(NRout);
            db.SaveChanges();
            return NRout.RouteID;

        }

        public bool Remove(int IdRoute)
        {
            try
            {
                var route = db.Routes.FirstOrDefault(x => x.RouteID == IdRoute);
                db.Routes.Remove(route);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<DomainModel.Model.Route> Search(RouteSearchModel sm)
        {
            var q = from Item in db.Routes select Item;
            if (sm.OriginID != null)
            {
                q = q.Where(x => x.OriginID == sm.OriginID);
            }
            if (sm.DestinationID != null)
            {
                q = q.Where(x => x.DestinationID == sm.DestinationID);
            }
            return q.ToList();
        }

        public bool Update(Route NRoute)
        {
            try
            {
                var route = db.Routes.FirstOrDefault(x => x.RouteID == NRoute.RouteID);
                route.RouteID = NRoute.RouteID;
                route.OriginID = NRoute.OriginID;
                route.DestinationID = NRoute.DestinationID;
                route.Price = NRoute.Price;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
