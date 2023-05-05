namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Trips = new HashSet<Trip>();
        }

        public int CustomerID { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string CustomerLastName { get; set; }

        [Required]
        [StringLength(5)]
        public string CustomerSubscriberNumber { get; set; }

        [Required]
        [StringLength(8)]
        public string CustomerTel { get; set; }

        [Required]
        [StringLength(12)]
        public string CustomerMobilel { get; set; }

        [Required]
        [StringLength(200)]
        public string CustomerAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
