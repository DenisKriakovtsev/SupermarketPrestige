﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrestigeHost.Host
{
    [DataContract] 
    public class WarehouseWorkersProxy
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Patronymic { get; set; }
        [DataMember] 
        public DateTime DateBeginWork { get; set; }
        [DataMember] 
        public int id_post { get; set; }
        [DataMember]
        public PostsProxy Posts { get; set; }
    } 
}
