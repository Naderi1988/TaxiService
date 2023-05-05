using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ViewModel.Trip
{
   public class TripFulInformation
    {
        public int TripID { get; set; }

        public int ReservationID { get; set; }

        public int CartextID { get; set; }
        public int CarID { get; set; }

        public int DriverID { get; set; }

        public int CustomerID { get; set; }

        public int OriginID { get; set; }

        public int DestinationID { get; set; }

       
        public DateTime StartTripData { get; set; }

        
        public DateTime FinishTripDate { get; set; }

        public int Price { get; set; }

        public int Hour { get; set; }
    }
}
