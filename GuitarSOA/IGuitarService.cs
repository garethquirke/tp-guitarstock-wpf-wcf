using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GuitarSOA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGuitarService" in both code and config file together.
    [ServiceContract]
    public interface IGuitarService
    {

        [OperationContract]
        List<Guitar> FindAll();

        [OperationContract]
        void Add(Guitar g);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        Guitar Edit(int id);

        [OperationContract]
        void SaveEdit(Guitar g);
    }
}
