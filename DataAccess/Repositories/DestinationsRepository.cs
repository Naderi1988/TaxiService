using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Services;
using DomainModel.Model;
using DomainModel.ViewModel;
using DomainModel.ViewModel.Destinition;

namespace DataAccess.Repositories
{
    public class DestinationsRepository : IDestinations ,IDisposable


    {
        Model4 db = new Model4();
       

        public void Dispose()
        {
            this.db.Dispose();
        }

        public Destination Get(int IdDestination)
        {
            var destination = db.Destinations.FirstOrDefault(x => x.DestinationID == IdDestination);
            return destination;
        }

        public List<Destination> GetAllDestination()
        {
            return db.Destinations.ToList();
        }

        public List<DestinitionListItem> GetAllForDrop()
        {
            var destination = from item in db.Destinations
                    select new DestinitionListItem
                    {
                        DestinationID = item.DestinationID
                        ,
                        DestinationsName = item.DestinationsName
                    };
            return destination.ToList();
        }

        public int RegisterDestination(Destination NDestination)
        {
            db.Destinations.Add(NDestination);
            db.SaveChanges();
            return NDestination.DestinationID;
        }

        public bool Remove(int IdDestination)
        {
            try
            {
                var destination = db.Destinations.FirstOrDefault(x => x.DestinationID == IdDestination);
                db.Destinations.Remove(destination);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

       
        public List<Destination> Search(DestinitionSearchModel sm)
        {
            var q = from Item in db.Destinations select Item;
            if (!string.IsNullOrEmpty(sm.DestinationsName))
            {
                q = q.Where(x => x.DestinationsName.StartsWith(sm.DestinationsName));
            }
            return q.ToList();
        }

        public bool Update(Destination NDestination)
        {
            try
            {
                var old = db.Destinations.FirstOrDefault(x => x.DestinationID == NDestination.DestinationID);
                old.DestinationsName = NDestination.DestinationsName;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}


