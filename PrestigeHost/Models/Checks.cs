namespace PrestigeHost.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Checks
    {
        public int id { get; set; }

        public int id_cashier { get; set; }

        public int id_product { get; set; }

        public int id_client { get; set; }

        public DateTime DatePurchase { get; set; }

        public decimal TotalSumm { get; set; }

        public string Info { get; set; }

        public int Quantity { get; set; }

        public virtual Cashiers Cashiers { get; set; }

        public virtual Clients Clients { get; set; }

        public virtual Products Products { get; set; }
    }
}
