namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            Trips = new HashSet<Trip>();
        }

        public int ReservationID { get; set; }

        [Required]
        [StringLength(20)]
        public string ReservationFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string ReservationLastName { get; set; }

        [Required]
        [StringLength(7)]
        public string ReservationUserName { get; set; }

        [Required]
        [StringLength(7)]
        public string ReservationPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
