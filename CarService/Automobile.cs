using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;


namespace CarService
{
    /// <summary>
    /// Class <see cref="Automobile"/> manages the <see cref="Auto"/> entity
    /// </summary>
    public class Automobile
    {
        /// <summary>
        /// Add a new object of type <see cref="Auto"/> in the database
        /// </summary>
        /// <param name="nrAuto"></param>
        /// <param name="serieSasiu"></param>
        /// <param name="codSasiu"></param>
        /// <param name="denumireSasiu"></param>
        /// <param name="clientId"></param>
        public static void Add(string nrAuto, string serieSasiu, string codSasiu, string denumireSasiu, int clientId)
        {
            int sasiuID = 0;
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {

                context.Database.Connection.Open();
                
                //Verifica daca exista deja acest sasiu 
                //var codSasiuExistent = context.SasiuSet.SingleOrDefault(s => s.CodSasiu == codSasiu);
                var denumireSasiuExistenta = context.SasiuSet.SingleOrDefault(s => s.Denumire == denumireSasiu);

                

                if (denumireSasiuExistenta != null)
                {
                    sasiuID = denumireSasiuExistenta.Id;
                }
                else
                {
                    Sasiu sasiu = new Sasiu()
                    {
                        CodSasiu = codSasiu,
                        Denumire = denumireSasiu
                    };
                    context.SasiuSet.Add(sasiu);
                    context.SaveChanges();
                    sasiuID = sasiu.Id;
                }

                try
                {
                    Auto auto = new Auto()
                    {
                        NumarAuto = nrAuto,
                        SerieSasiu = serieSasiu,
                        SasiuId =  sasiuID,
                        ClientId = clientId
                    };
                    context.AutoSet.Add(auto);
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
        /// Delete method, deletes an object from the DB. It requires the id of the object
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                Auto auto = new Auto()
                {
                    Id = id
                };

                context.AutoSet.Attach(auto);
                context.AutoSet.Remove(auto);
                context.SaveChanges();
            }

        }

        /// <summary>
        /// Return an object of type Auto or null if the object is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Auto GetById(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();


                var _auto = context.MecanicSet.SingleOrDefault(a => a.Id == id);
                if (_auto != null)
                {
                    Auto auto = new Auto()
                    {
                        Id = id
                    };
                    context.AutoSet.Attach(auto);
                    return auto;
                }
            }
            return null;
        }

        /// <summary>
        /// Update method, changes the values of an object of type <see cref="Auto"/> 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nrAuto"></param>
        /// <param name="serieSasiu"></param>
        /// <param name="codSasiu"></param>
        /// <param name="denumireSasiu"></param>
        /// <param name="clientId"></param>
        public static void Update(int id, string nrAuto, string serieSasiu, string codSasiu, string denumireSasiu, int clientId)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {

                context.Database.Connection.Open();

                var autoId = context.AutoSet.SingleOrDefault(i => i.Id == id);
                var sasiu = context.SasiuSet.SingleOrDefault(s => s.Id == autoId.SasiuId);

                if (autoId != null)
                {
                    autoId.NumarAuto = nrAuto;
                    autoId.SerieSasiu = serieSasiu;
                    sasiu.CodSasiu = codSasiu;
                    sasiu.Denumire = denumireSasiu;
                    autoId.ClientId = clientId;
                    context.SaveChanges();
                }
            }
            
        }
    }
}
