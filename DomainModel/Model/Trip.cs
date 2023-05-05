namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trip")]
    public partial class Trip
    {
        public int TripID { get; set; }

        public int ReservationID { get; set; }

        public int DriverID { get; set; }

        public int CarID { get; set; }

        public int CustomerID { get; set; }

        public int OriginID { get; set; }

        public int DestinationID { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartTripData { get; set; }

        public int Price { get; set; }

        public bool Clearing { get; set; }

        public virtual Car Car { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Destination Destination { get; set; }

        public virtual Origin Origin { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
