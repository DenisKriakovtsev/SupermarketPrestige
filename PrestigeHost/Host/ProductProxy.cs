using System; 
using System.Runtime.Serialization; 

namespace PrestigeHost.Host
{
    [DataContract] 
    public class ProductProxy
    {
        [DataMember]
        public int id { get; set; } 
        [DataMember]
        public string NameProduct { get; set; } 
        [DataMember]
        public int CodeProduct { get; set; } 
        [DataMember]
        public double Price { get; set; } 
        [DataMember]
        public int Id_Categories { get; set; }
        [DataMember]
        public int Id_Manufacturer { get; set; }
        [DataMember]
        public DateTime DateOfManufacture { get; set; } 
        [DataMember]
        public DateTime BestBefore { get; set; }
        [DataMember]
        public string Composition { get; set; }
    }
}
