using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleSibiWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SibiSampleWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SibiSampleWCF.svc or SibiSampleWCF.svc.cs at the Solution Explorer and start debugging.
    public class SibiSampleWCF : ISibiSampleWCF
    {

        private WCFSampleEntities mde = new WCFSampleEntities();
        public List<Product> find(int id)
        {
            return mde.Products.Where(p => p.Id == id).ToList();
        }

        public List<Product> findAll()
        {
            return mde.Products.ToList();
        }

        public List<Product> findByDate(DateTime CreationDate)
        {
            return mde.Products.Where(p => p.CreationDate.Value == CreationDate).ToList();
        }
    }
}
