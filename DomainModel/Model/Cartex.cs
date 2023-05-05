namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cartex")]
    public partial class Cartex
    {
        public int CartexID { get; set; }

        public int DriverID { get; set; }

        public int TripID { get; set; }

        public int DebiteTripCount { get; set; }

        public int TotalDebit { get; set; }

        public virtual Driver Driver { get; set; }
    }
}
