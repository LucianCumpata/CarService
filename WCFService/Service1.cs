﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CarService;

namespace WCFService
{
    public class CarService : ICarService
    {

        bool InterfaceClients.AddClient(Client client)
        {
            CarServiceAPI.AddClient(client);
            return true;
        }
    }
}
