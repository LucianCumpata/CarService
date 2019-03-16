using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    public class Core
    {
        public static void TestClient()
        {
            //Client x = new Client();
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                Client client = new Client()
                {
                    Nume = "Cumpata",
                    Prenume = "Lucian",
                    Telefon = "0720345686",
                    Email = "cumpata.lu@outlook.com"
                };

                Auto auto = new Auto()
                {
                    Client = client,
                    NumarAuto = "IS 666 LOL"
                };

                context.ClientSet.Add(client);
                context.AutoSet.Add(auto);
                context.SaveChanges();
            }
        }

    }
}
