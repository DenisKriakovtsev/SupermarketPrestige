using PrestigeHost.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PrestigeHost.Host
{
    [ServiceContract]
    interface IPrestigeService
    {
        [OperationContract]
        List<Product> Product();
 
    }
}