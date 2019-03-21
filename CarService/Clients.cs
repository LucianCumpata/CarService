using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace CarService
{
    /// <summary>
    /// Manages the clients
    /// </summary>
    public class Clients
    {
        
        private static List<Client> GatherAll()
        {
            List<Client> clients = new List<Client>();
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();
                var _clients = context.ClientSet;
                foreach (var client in _clients)
                {
                    clients.Add(client);
                }
            }
            return clients;
        }

        /// <summary>
        /// Returns a string containing the Firstname and Lastname of the clients
        /// </summary>
        /// <returns></returns>
        public static string ShowAll()
        {
            var _clients = GatherAll();
            string allClients = "";
            //uint counter = 0;
            foreach (var _client in _clients)
            {
                allClients += _client.Nume +" "+ _client.Prenume + "\n";
            }
            return allClients;
        }

        /// <summary>
        /// Return an object of type Client or null if the object is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Client GetById(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();
                var _client = context.ClientSet.SingleOrDefault(c => c.Id == id);
                if (_client != null)
                {
                    Client client = new Client()
                    {
                        Id = id
                    };
                    context.ClientSet.Attach(client);
                    return client;
                }
            }
            return null;
        }

        /// <summary>
        /// Add method, adds a new client
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="addrs"></param>
        /// <param name="localitate"></param>
        /// <param name="judet"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        public static void Add(string fName, string lName, string addrs, string localitate, string judet, string tel, string email)
        {   
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {

                context.Database.Connection.Open();

                try
                {
                    Client client = new Client()
                    {
                        Nume = fName,
                        Prenume = lName,
                        Adresa = addrs,
                        Localitate = localitate,
                        Judet = judet,
                        Telefon = tel,
                        Email = email
                    };

                    context.ClientSet.Add(client);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (DbEntityValidationResult entityErr in ex.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            //Console.WriteLine("Error: {0}", error.ErrorMessage);
                            //return error.ErrorMessage;
                            throw;

                        }
                    }
                }

            }
        }

        public static int Lookup(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                Client client = new Client()
                {

                };
                
                return 0;
            }
        }

        public static void Update(string name)
        {

        }

        /// <summary>
        /// Delete method, deletes an object from the DB. It requires the id of the object
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int? id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                if (id != null)
                {
                    Client client = new Client()
                    {
                        Id = id.GetValueOrDefault()
                    };

                    context.ClientSet.Attach(client);
                    context.ClientSet.Remove(client);
                    context.SaveChanges();
                }

            }
        }
        
    }
}
