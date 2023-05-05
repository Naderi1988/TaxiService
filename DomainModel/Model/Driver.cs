namespace DomainModel.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Driver")]
    public partial class Driver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Driver()
        {
            Cartexes = new HashSet<Cartex>();
        }

        public int DriverID { get; set; }

        [Required]
        [StringLength(20)]
        public string DriverFirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string DriverLastName { get; set; }

        [Required]
        [StringLength(10)]
        public string DriverNationalCode { get; set; }

        [Required]
        [StringLength(8)]
        public string DriverTell { get; set; }

        [Required]
        [StringLength(12)]
        public string DriverMobile { get; set; }

        [StringLength(10)]
        public string DraiverAdress { get; set; }

        [StringLength(2000)]
        public string picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cartex> Cartexes { get; set; }
    }
}
