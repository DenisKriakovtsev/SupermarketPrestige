namespace PrestigeHost.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WarehouseWorkers
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Patronymic { get; set; }

        public DateTime DateBeginWork { get; set; }

        public int id_post { get; set; }

        public virtual Posts Posts { get; set; }
    }
}