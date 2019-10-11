using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrestigeHost.Host
{
    [DataContract]
    public class ClientsProxy
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public int? NumberCard { get; set; }
        [DataMember]
        public bool? Cash { get; set; }
    }
}
