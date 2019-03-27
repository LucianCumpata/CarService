using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class CarServiceAPI
    {
        private static ModelCarServiceContainer _dbContext;

        public static void SetContext(ModelCarServiceContainer context)
        {
            _dbContext = context;
        }
        public static void DisposeModelCarServiceContext()
        {
            _dbContext.Dispose();
        }

        public static ModelCarServiceContainer GetContext()
        {
            return _dbContext;
        }

        public static void AddMecanic(Mecanic m)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Mecanic> mecanic = new Repository<Mecanic>(dbContext);
                mecanic.Add(m);   
            }
        }

        public static void DeleteMecanic(Mecanic m)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Mecanic> mecanic = new Repository<Mecanic>(dbContext);
                mecanic.Delete(m);
            }
        }

        public static Mecanic GetMecanicById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Mecanic> mecanic = new Repository<Mecanic>(dbContext);
                return mecanic.GetById(id);
            }
        }

        public static void UpdateMecanic(Mecanic m)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Mecanic> mecanic = new Repository<Mecanic>(dbContext);
                mecanic.Update(m);
            }
        }


        public static void AddClient(Client c)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Client> client = new Repository<Client>(dbContext);
                client.Add(c);
            }
        }

        public static IEnumerable<Client> ListAllClients()
        {
            SetContext(new ModelCarServiceContainer());
            Repository<Client> client = new Repository<Client>(GetContext());
            return client.List();
        }

        /*
        public static IEnumerable<Client> ListClientsByName(string n)
        {
            SetContext(new ModelCarServiceContainer());
            Repository<Client> client = new Repository<Client>(GetContext());
            var clientsByName = _dbContext.ClientSet.SelectMany(c => c.Nume);
            return clientsByName;
        }
        */

        public static void DeleteClient(Client c)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Client> client = new Repository<Client>(dbContext);
                client.Delete(c);
            }
        }

        public static Client GetClientById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Client> client = new Repository<Client>(dbContext);
                return client.GetById(id);
            }
        }

        public static IEnumerable<Client> ListClientsByName(string name)
        {
            Expression<Func<Client,bool>> FilterByClientName(string n)
            {
                return x => x.Nume == n || x.Prenume == n;
            }

            SetContext(new ModelCarServiceContainer());
            Repository<Client> client = new Repository<Client>(GetContext());
            var result = _dbContext.ClientSet.Where(FilterByClientName(name));
            return result;
        }

        public static void UpdateClient(Client c)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Client> client = new Repository<Client>(dbContext);
                client.Update(c);
            }
        }


        public static void AddMaterial(Material material)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Material> materialRepository = new Repository<Material>(dbContext);
                materialRepository.Add(material);
            }
        }

        public static void DeleteMaterial(Material material)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Material> materialRepository = new Repository<Material>(dbContext);
                materialRepository.Delete(material);
            }
        }

        public static Material GetMaterialById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Material> materialRepository = new Repository<Material>(dbContext);
                return materialRepository.GetById(id);
            }
        }

        public static void UpdateMaterial(Material material)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Material> materialRepository = new Repository<Material>(dbContext);
                materialRepository.Update(material);
            }
        }


        public static void AddOperatie(Operatie operatie)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Operatie> operatieRepository = new Repository<Operatie>(dbContext);
                operatieRepository.Add(operatie);
            }
        }

        public static void DeleteOperatie(Operatie operatie)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Operatie> operatieRepository = new Repository<Operatie>(dbContext);
                operatieRepository.Delete(operatie);
            }
        }

        public static Operatie GetOperatieById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Operatie> operatieRepository = new Repository<Operatie>(dbContext);
                return operatieRepository.GetById(id);
            }
        }

        public static void UpdateOperatie(Operatie operatie)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Operatie> operatieRepository = new Repository<Operatie>(dbContext);
                operatieRepository.Update(operatie);
            }
        }


        public static void AddAuto(Auto auto, Client client, Sasiu sasiu)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Auto> autoRepository = new Repository<Auto>(dbContext);
                //Repository<Client> clientRepository = new Repository<Client>(dbContext);
                Repository<Sasiu> sasiuRepository = new Repository<Sasiu>(dbContext);
                sasiuRepository.Add(sasiu);
                auto.ClientId = client.Id;
                auto.SasiuId = sasiu.Id;
                autoRepository.Add(auto);
            }
        }

        
        public static IEnumerable<Auto> ListAutosByClient(Client client)
        {
            Expression<Func<Auto, bool>> FilterByClientId(int id)
            {
                return x => x.ClientId == id;
            }

            SetContext(new ModelCarServiceContainer());
            Repository<Auto> auto = new Repository<Auto>(GetContext());

            var result = _dbContext.AutoSet.Where(FilterByClientId(client.Id));
            //return auto.List(_dbContext.AutoSet.SqlQuery("SELECT * FROM AutoSet WHERE ClientId = @p0", client.Id));
            //return auto.List(result);
            return result;
        }

        public static void DeleteAuto(Auto auto)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Auto> autoRepository = new Repository<Auto>(dbContext);
                autoRepository.Delete(auto);
            }
        }

        public static Auto GetAutoById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Auto> autoRepository = new Repository<Auto>(dbContext);
                return autoRepository.GetById(id);
            }
        }

        public static void UpdateAuto(Auto auto)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Auto> autoRepository = new Repository<Auto>(dbContext);
                autoRepository.Update(auto);
            }
        }


        public static void AddComanda(Comanda comanda, Client client, Auto auto)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Comanda> comandaRepository = new Repository<Comanda>(dbContext);
                comanda.ClientId = client.Id;
                comanda.AutoId = auto.Id;
                comandaRepository.Add(comanda);
            }
        }

        public static void DeleteComanda(Comanda comanda)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Comanda> comandaRepository = new Repository<Comanda>(dbContext);
                comandaRepository.Delete(comanda);
            }
        }

        public static Comanda GetComandaById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Comanda> comandaRepository = new Repository<Comanda>(dbContext);
                return comandaRepository.GetById(id);
            }
        }

        public static void UpdateComanda(Comanda comanda)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Comanda> comandaRepository = new Repository<Comanda>(dbContext);
                comandaRepository.Update(comanda);
            }
        }


        public static void AddImagine(Imagine imagine, DetaliuComanda detaliu)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Imagine> imagineRepository = new Repository<Imagine>(dbContext);
                imagine.DetaliuComandaId=detaliu.Id;
                imagineRepository.Add(imagine);
            }
        }

        public static void DeleteImagine(Imagine imagine)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Imagine> imagineRepository = new Repository<Imagine>(dbContext);
                imagineRepository.Delete(imagine);
            }
        }

        public static Imagine GetImagineById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Imagine> imagineRepository = new Repository<Imagine>(dbContext);
                return imagineRepository.GetById(id);
            }
        }

        public static void UpdateImagine(Imagine imagine)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<Imagine> imagineRepository = new Repository<Imagine>(dbContext);
                imagineRepository.Update(imagine);
            }
        }


        public static void AddDetaliuComanda(DetaliuComanda detaliu, Comanda comanda, Material material, Operatie operatie, Mecanic mecanic)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<DetaliuComanda> detaliuComandaRepository = new Repository<DetaliuComanda>(dbContext);
                detaliu.ComandaId = comanda.Id;
                detaliu.MaterialId = material.Id;
                detaliu.OperatieId = operatie.Id;
                detaliu.MecanicId = mecanic.Id;
                detaliuComandaRepository.Add(detaliu);
            }
        }

        public static void DeleteDetaliuComanda(DetaliuComanda detaliu)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<DetaliuComanda> detaliuComandaRepository = new Repository<DetaliuComanda>(dbContext);
                detaliuComandaRepository.Delete(detaliu);
            }
        }

        public static DetaliuComanda GetDetaliuComandaById(int id)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<DetaliuComanda> detaliuComandaRepository = new Repository<DetaliuComanda>(dbContext);
                return detaliuComandaRepository.GetById(id);
            }
        }

        public static void UpdateDetaliuComanda(DetaliuComanda detaliu)
        {
            using (ModelCarServiceContainer dbContext = new ModelCarServiceContainer())
            {
                Repository<DetaliuComanda> detaliuComandaRepository = new Repository<DetaliuComanda>(dbContext);
                detaliuComandaRepository.Update(detaliu);
            }
        }


    }
}
