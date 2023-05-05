using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Services;
using DomainModel.ViewModel;
using DomainModel.Model;
using DomainModel.ViewModel.Trip;

namespace DataAccess.Repositories
{
    public class TripRepository : ITrip, IDisposable

    {
        Model4 db = new Model4();

        public bool Clear(Trip NTrip)
        {
            var old = db.Trips.FirstOrDefault(x => x.TripID == NTrip.TripID);
            old.Clearing = false;
            db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            this.db.Dispose();
        }

        public Trip Get(int IdTrip)
        {
            var trip = db.Trips.FirstOrDefault(x => x.TripID == IdTrip);
            return trip;
        }

        public List<Trip> GetAllTrip()
        {
            return db.Trips.ToList();
        }

        public List<TripFulInformation> GetTripList()
        {
            throw new NotImplementedException();
        }

        public int RegisterTrip(Trip NTrip)
        {
            db.Trips.Add(NTrip);
            db.SaveChanges();
            return NTrip.TripID;
        }

        public bool Remove(int IdTrip)
        {
            try
            {
                var trip = db.Trips.FirstOrDefault(x => x.TripID == IdTrip);
                db.Trips.Remove(trip);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Trip> Search(TripSearchModel sm)
        {
            var q = from Item in db.Trips select Item;
            if (sm.DriverID != null)
            {
                q = q.Where(x => x.DriverID == sm.DriverID);
            }
            if (sm.CustomerID != null)
            {
                q = q.Where(x => x.CustomerID == sm.CustomerID);
            }
            return q.ToList();
        }

        public bool Update(Trip NTrip)
        {
            try
            {
                var old = db.Trips.FirstOrDefault(x => x.TripID == NTrip.TripID);

                old.CustomerID = NTrip.CustomerID;
                old.OriginID = NTrip.OriginID;
                old.StartTripData = NTrip.StartTripData;
                old.Price = NTrip.Price;
                old.DestinationID = NTrip.DestinationID;
                old.DriverID = NTrip.DriverID;
                old.TripID = NTrip.TripID;
                old.ReservationID = NTrip.ReservationID;
                old.CarID = NTrip.CarID;
                old.Clearing = NTrip.Clearing;
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
