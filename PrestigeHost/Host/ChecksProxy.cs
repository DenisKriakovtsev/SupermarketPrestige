using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrestigeHost.Host
{
    [DataContract] 
    public class ChecksProxy
    { 
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int id_cashier { get; set; }
        [DataMember]
        public int id_product { get; set; }
        [DataMember]
        public int id_client { get; set; }
        [DataMember]
        public DateTime DatePurchase { get; set; }
        [DataMember]
        public decimal TotalSumm { get; set; }
        [DataMember]
        public string Info { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public CashiersProxy Cashiers { get; set; }
        [DataMember]
        public ClientsProxy Clients { get; set; }
        [DataMember]
        public ProductProxy Products { get; set; }
    }
}