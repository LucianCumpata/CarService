using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Class <see cref="Orders"/> manages objects of type <see cref="Comanda"/> 
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// Adds a new object of type <see cref="Comanda"/>
        /// </summary>
        /// <param name="autoId"></param>
        /// <param name="clientId"></param>
        /// <param name="stare"></param>
        /// <param name="dataProgramare"></param>
        /// <param name="dataFinalizare"></param>
        /// <param name="kmBord"></param>
        /// <param name="descriere"></param>
        public static void Add(int autoId, int clientId, string stare, DateTime dataProgramare, DateTime dataFinalizare, int kmBord, string descriere)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {

                context.Database.Connection.Open();

                try
                {
                    Comanda comanda = new Comanda()
                    {
                        AutoId = autoId,
                        ClientId = clientId,
                        StareComanda = stare,
                        DataSystem = DateTime.Now,
                        DataProgramare = dataProgramare,
                        DataFinalizare = dataFinalizare,
                        KmBord = kmBord,
                        Descriere = descriere,
                        ValoarePiese = 0
                    };

                    context.ComandaSet.Add(comanda);
                    context.SaveChanges();

                }
                catch (DbEntityValidationException ex)
                {
                    foreach (DbEntityValidationResult entityErr in ex.EntityValidationErrors)
                    {
                        foreach (DbValidationError error in entityErr.ValidationErrors)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Return an object of type <see cref="Auto"/> or <code>null</code> if the object is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Comanda GetById(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();


                var _comanda = context.MecanicSet.SingleOrDefault(m => m.Id == id);
                if (_comanda != null)
                {
                    Comanda comanda = new Comanda()
                    {
                        Id = id
                    };
                    context.ComandaSet.Attach(comanda);
                    return comanda;
                }
            }
            return null;
        }


    }
}
