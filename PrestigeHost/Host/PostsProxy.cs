using System.Runtime.Serialization;

namespace PrestigeHost.Host
{
    [DataContract]
    public class PostsProxy
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string TypePost { get; set; }
    }
}
