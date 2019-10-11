namespace PrestigeHost.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Check
    {
        public int id { get; set; }

        public int id_cashier { get; set; }

        public int id_product { get; set; }

        public int id_client { get; set; }

        public DateTime DatePurchase { get; set; }

        public decimal TotalSumm { get; set; }

        public string Info { get; set; }

        public int Quantity { get; set; }

        public virtual Cashier Cashier { get; set; }

        public virtual Client Client { get; set; }

        public virtual Product Product { get; set; }
    }
}
