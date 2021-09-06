using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleSibiWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISibiSampleWCF" in both code and config file together.
    [ServiceContract]
    public interface ISibiSampleWCF
    {
        [OperationContract]
        List<Product> findAll();

        [OperationContract]
        List<Product> find(int id);

        [OperationContract]
        List<Product> findByDate(DateTime CreationDate);
    }
}
