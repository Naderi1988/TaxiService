using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Trip;

namespace DataAccess.Services
{
    interface ITrip
    {
        int RegisterTrip(Trip NTrip);
        bool Remove(int IdTrip);
        bool Update(Trip NTrip);
        bool Clear(Trip NTrip);
        List<Trip> GetAllTrip();
        Trip Get(int IdTrip);
        List<Trip> Search(TripSearchModel sm);
        List<TripFulInformation> GetTripList();
    }
}
