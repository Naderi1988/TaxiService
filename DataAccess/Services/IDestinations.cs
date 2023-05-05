using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Model;
using DomainModel.ViewModel.Destinition;

namespace DataAccess.Services
{
    interface IDestinations

    {
        int RegisterDestination(Destination NDestination);
        bool Remove(int IdDestination);
        bool Update(Destination NDestination);
        Destination Get(int IdDestination);
        List<Destination> GetAllDestination();
        List<Destination> Search(DestinitionSearchModel sm);
        List<DomainModel.ViewModel.Destinition.DestinitionListItem> GetAllForDrop();
    }
}
