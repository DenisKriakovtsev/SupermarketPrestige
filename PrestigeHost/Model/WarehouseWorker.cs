namespace PrestigeHost.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WarehouseWorker
    {
        public int id { get; set; }

        public int id_product { get; set; }

        public DateTime? DateReceipt { get; set; }

        public DateTime? DateSale { get; set; }

        public bool? Status { get; set; }

        public int Quantity { get; set; }

        public int id_post { get; set; }

        [Required]
        public string FIO { get; set; }

        public virtual Post Post { get; set; }

        public virtual Product Product { get; set; }
    }
}
