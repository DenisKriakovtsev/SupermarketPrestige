namespace PrestigeHost.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Products()
        {
            Checks = new HashSet<Checks>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        public int CodeProduct { get; set; }

        public double Price { get; set; }

        public int Id_Categories { get; set; }

        public int Id_Manufacturer { get; set; }

        public DateTime DateOfManufacture { get; set; }

        public DateTime BestBefore { get; set; }

        [Required]
        public string Composition { get; set; }

        public virtual Categories Categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Checks> Checks { get; set; }

        public virtual Manufacturers Manufacturers { get; set; }
    }
}
