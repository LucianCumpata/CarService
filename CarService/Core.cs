using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Core
    {
        /// <summary>
        /// AddClient method adds a new client to the DB.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="addrs"></param>
        /// <param name="localitate"></param>
        /// <param name="judet"></param>
        /// <param name="tel"></param>
        /// <param name="email"></param>
        public static void AddClient(string fName, string lName, string addrs, string localitate, string judet, string tel, string email)
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
                            
                        }
                    }
                }
               
            }
        }
        public static void TestClient()
        {
            //Client x = new Client();
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                /*
                Client client = new Client()
                {
                    Nume = "123456789012345678",
                    Prenume = "dhfgjjhjkdfj",
                    Telefon = "235346",
                    Email = "sdsfd@outlook.com",
                    Adresa = "Str.bafafgr",
                    Judet = "Iasi",
                    Localitate = "Iasi"
                };
                */
                /*
                Auto auto = new Auto()
                {
                    Client = client,
                    NumarAuto = "IS 666 LOL"
                };
                */
                //context.ClientSet.Add(client);
                //context.AutoSet.Add(auto);
                //context.SaveChanges();
            }
        }

    }
}
