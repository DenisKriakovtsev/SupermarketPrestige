namespace PrestigeHost.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Checks = new HashSet<Check>();
            WarehouseWorkers = new HashSet<WarehouseWorker>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string NameProduct { get; set; }

        public int CodeProduct { get; set; }

        public double Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Categories { get; set; }

        [Required]
        [StringLength(50)]
        public string Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Check> Checks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseWorker> WarehouseWorkers { get; set; }
    }
}
