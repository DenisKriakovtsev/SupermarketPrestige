using System.Runtime.Serialization; 

namespace PrestigeHost.Host
{
    [DataContract]
    public class ManufacturersProxy
    {
        [DataMember] 
        public int id { get; set; }
        [DataMember] 
        public string Manufactured { get; set; }
    } 
}
