using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarService;

namespace WCFService
{
   [ServiceContract]
   interface InterfaceClients
    {
        [OperationContract]
        bool AddClient(Client client);
    }

    [ServiceContract]
    interface ICarService: InterfaceClients
    {

    }
}
