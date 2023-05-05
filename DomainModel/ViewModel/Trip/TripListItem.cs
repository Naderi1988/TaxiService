using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel.Trip
{
   public class TripListItem
    {
        public int TripID { get; set; }

       
        public int DriverID { get; set; }

        public int CustomerID { get; set; }

        public int OriginID { get; set; }

        public int DestinationID { get; set; }
    }
}
