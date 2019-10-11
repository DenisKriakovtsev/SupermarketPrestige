using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrestigeHost.Host
{
    [DataContract]
    public class CategoriesProxy
    {
        [DataMember]
        public int id { get; set; }
        [DataMember] 
        public string Category { get; set; } 
    }
}
