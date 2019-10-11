using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestigeHost.Model;

namespace PrestigeHost.Host
{
    public class PrestigeService : IPrestigeService
    {
        PrestigeModels context = new PrestigeModels();

        public List<Product> Product()
        {
            return context.Products.ToList();
        }
    }
}
