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
        void AddClient(Client client);

        [OperationContract]
        IEnumerable<Client> ListAllClients();

        [OperationContract]
        void DeleteClient(Client c);

        [OperationContract]
        Client GetClientById(int id);

        [OperationContract]
        IEnumerable<Client> ListClientsByName(string name);

        [OperationContract]
        void UpdateClient(Client c);
    }

    [ServiceContract]
    interface InterfaceMecanics
    {
        [OperationContract]
        void AddMecanic(Mecanic m);

        [OperationContract]
        void DeleteMecanic(Mecanic m);

        [OperationContract]
        Mecanic GetMecanicById(int Id);

        [OperationContract]
        IEnumerable<Mecanic> ListAllMecanics();

        [OperationContract]
        void UpdateMecanic(Mecanic m);
    }

    [ServiceContract]
    interface InterfaceMaterial
    {
        [OperationContract]
        void AddMaterial(Material m);

        [OperationContract]
        void DeleteMaterial(Material m);

        [OperationContract]
        Material GetMaterialById(int Id);

        [OperationContract]
        void UpdateMaterial(Material m);
    }

    [ServiceContract]
    interface InterfaceOperatie
    {
        [OperationContract]
        void AddOperatie(Operatie o);

        [OperationContract]
        void DeleteOperatie(Operatie o);

        [OperationContract]
        Operatie GetOperatieById(int Id);

        [OperationContract]
        void UpdateOperatie(Operatie o);
    }

    [ServiceContract]
    interface InterfaceAuto
    {
        [OperationContract]
        void AddAuto(Auto auto, Client client, Sasiu sasiu);

        [OperationContract]
        IEnumerable<Auto> ListAutosByClient(Client client);

        [OperationContract]
        void DeleteAuto(Auto auto);

        [OperationContract]
        Auto GetAutoById(int Id);

        [OperationContract]
        void UpdateAuto(Auto auto);
    }

    [ServiceContract]
    interface InterfaceComanda
    {
        [OperationContract]
        void AddComanda(Comanda comanda, Client client, Auto auto);

        [OperationContract]
        void DeleteComanda(Comanda comanda);

        [OperationContract]
        Comanda GetComandaById(int id);

        [OperationContract]
        IEnumerable<Comanda> ListOrdersByAuto(Auto auto);

        [OperationContract]
        void UpdateComanda(Comanda comanda);
    }

    [ServiceContract]
    interface InterfaceDetaliuComanda
    {
        [OperationContract]
        void AddDetaliuComanda(DetaliuComanda d, Comanda c, Material ma, Operatie o, Mecanic m);

        [OperationContract]
        void DeleteDetaliuComanda(DetaliuComanda detaliu);

        [OperationContract]
        DetaliuComanda GetDetaliuComandaById(int id);

        [OperationContract]
        IEnumerable<DetaliuComanda> ListDetaliuComandaByComanda(Comanda comanda);

        [OperationContract]
        void UpdateDetaliuComanda(DetaliuComanda detaliu);
    }

    [ServiceContract]
    interface ICarService: InterfaceClients , InterfaceMecanics , InterfaceMaterial , InterfaceOperatie,
        InterfaceAuto, InterfaceComanda , InterfaceDetaliuComanda
    {

    }
}
