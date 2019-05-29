using System;
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

        void InterfaceClients.AddClient(Client client)
        {
            CarServiceAPI.AddClient(client);
        }

        IEnumerable<Client> InterfaceClients.ListAllClients()
        {
            return CarServiceAPI.ListAllClients();
        }

        void InterfaceClients.DeleteClient(Client c)
        {
            CarServiceAPI.DeleteClient(c);
        }

        Client InterfaceClients.GetClientById(int id)
        {
            return CarServiceAPI.GetClientById(id);
        }

        IEnumerable<Client> InterfaceClients.ListClientsByName(string name)
        {
            return CarServiceAPI.ListClientsByName(name);
        }

        void InterfaceClients.UpdateClient(Client c)
        {
            CarServiceAPI.UpdateClient(c);
        }

        void InterfaceMecanics.AddMecanic(Mecanic m)
        {
            CarServiceAPI.AddMecanic(m);
        }

        void InterfaceMecanics.DeleteMecanic(Mecanic m)
        {
            CarServiceAPI.DeleteMecanic(m);
        }

        Mecanic InterfaceMecanics.GetMecanicById(int Id)
        {
            return CarServiceAPI.GetMecanicById(Id);
        }

        IEnumerable<Mecanic> InterfaceMecanics.ListAllMecanics()
        {
            return CarServiceAPI.ListAllMecanics();
        }

        void InterfaceMecanics.UpdateMecanic(Mecanic m)
        {
            CarServiceAPI.UpdateMecanic(m);
        }

        void InterfaceMaterial.AddMaterial(Material m)
        {
            CarServiceAPI.AddMaterial(m);
        }

        void InterfaceMaterial.DeleteMaterial(Material m)
        {
            CarServiceAPI.DeleteMaterial(m);
        }

        Material InterfaceMaterial.GetMaterialById(int Id)
        {
            return CarServiceAPI.GetMaterialById(Id);
        }

        void InterfaceMaterial.UpdateMaterial(Material m)
        {
            CarServiceAPI.UpdateMaterial(m);
        }

        void InterfaceOperatie.AddOperatie(Operatie o)
        {
            CarServiceAPI.AddOperatie(o);
        }

        void InterfaceOperatie.DeleteOperatie(Operatie o)
        {
            CarServiceAPI.DeleteOperatie(o);
        }

        Operatie InterfaceOperatie.GetOperatieById(int Id)
        {
            return CarServiceAPI.GetOperatieById(Id);
        }

        void InterfaceOperatie.UpdateOperatie(Operatie o)
        {
            CarServiceAPI.UpdateOperatie(o);
        }

        void InterfaceAuto.AddAuto(Auto auto, Client client, Sasiu sasiu)
        {
            CarServiceAPI.AddAuto(auto, client, sasiu);
        }

        IEnumerable<Auto> InterfaceAuto.ListAutosByClient(Client client)
        {
            return CarServiceAPI.ListAutosByClient(client);
        }

        void InterfaceAuto.DeleteAuto(Auto auto)
        {
            CarServiceAPI.DeleteAuto(auto);
        }

        Auto InterfaceAuto.GetAutoById(int Id)
        {
            return CarServiceAPI.GetAutoById(Id);
        }

        void InterfaceAuto.UpdateAuto(Auto auto)
        {
            CarServiceAPI.UpdateAuto(auto);
        }

        void InterfaceComanda.AddComanda(Comanda comanda, Client client, Auto auto)
        {
            CarServiceAPI.AddComanda(comanda, client, auto);
        }

        void InterfaceComanda.DeleteComanda(Comanda comanda)
        {
            CarServiceAPI.DeleteComanda(comanda);
        }

        Comanda InterfaceComanda.GetComandaById(int id)
        {
            return CarServiceAPI.GetComandaById(id);
        }

        IEnumerable<Comanda> InterfaceComanda.ListOrdersByAuto(Auto auto)
        {
            return CarServiceAPI.ListOrdersByAuto(auto);
        }

        void InterfaceComanda.UpdateComanda(Comanda comanda)
        {
            CarServiceAPI.UpdateComanda(comanda);
        }

        void InterfaceDetaliuComanda.AddDetaliuComanda(DetaliuComanda d, Comanda c, Material ma, Operatie o, Mecanic m)
        {
            CarServiceAPI.AddDetaliuComanda(d, c, ma, o, m);
        }

        void InterfaceDetaliuComanda.DeleteDetaliuComanda(DetaliuComanda detaliu)
        {
            CarServiceAPI.DeleteDetaliuComanda(detaliu);
        }

        DetaliuComanda InterfaceDetaliuComanda.GetDetaliuComandaById(int id)
        {
            return CarServiceAPI.GetDetaliuComandaById(id);
        }

        IEnumerable<DetaliuComanda> InterfaceDetaliuComanda.ListDetaliuComandaByComanda(Comanda comanda)
        {
            return CarServiceAPI.ListDetaliuComandaByComanda(comanda);
        }

        void InterfaceDetaliuComanda.UpdateDetaliuComanda(DetaliuComanda detaliu)
        {
            CarServiceAPI.UpdateDetaliuComanda(detaliu);
        }
    }
}
