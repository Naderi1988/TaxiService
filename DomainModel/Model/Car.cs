namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            Trips = new HashSet<Trip>();
        }

        public int CarID { get; set; }

        [Required]
        [StringLength(20)]
        public string CarMake { get; set; }

        [Required]
        [StringLength(30)]
        public string CarModel { get; set; }

        [Required]
        [StringLength(10)]
        public string CarModelYear { get; set; }

        [Required]
        [StringLength(20)]
        public string CarColor { get; set; }

        [Required]
        [StringLength(15)]
        public string CarNumberPlate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
