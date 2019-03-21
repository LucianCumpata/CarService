using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Manages the <see cref="Material"/> 
    /// </summary>
    public class Materials
    {
        /// <summary>
        /// Adds a new object of type <see cref="Material"/>
        /// </summary>
        /// <param name="denumire"></param>
        /// <param name="cantitate"></param>
        /// <param name="pret"></param>
        /// <param name="dataAprovizionare"></param>
        public static void Add(string denumire, Decimal cantitate, Decimal pret, DateTime dataAprovizionare)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                try
                {
                    Material material = new Material()
                    {
                        Denumire = denumire,
                        Cantitate = cantitate,
                        Pret = pret,
                        DataAprovizionare = dataAprovizionare
                    };

                    context.MaterialSet.Add(material);
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
        /// Deletes an object of type <see cref="Material"/>
        /// </summary>
        /// <param name="id"></param>
        public static void Delete (int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                Material material = new Material()
                {
                    Id = id
                };

                context.MaterialSet.Attach(material);
                context.MaterialSet.Remove(material);
                context.SaveChanges();
            }
        }
        
    }
}
