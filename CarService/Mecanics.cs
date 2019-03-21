using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Manages the Mecanic entity
    /// </summary>
    public class Mecanics
    {
    /// <summary>
    /// Add method, adds a new mecanic 
    /// </summary>
    /// <param name="nume"></param>
    /// <param name="prenume"></param>    
        public static void Add(string nume, string prenume)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                try
                {
                    Mecanic mecanic = new Mecanic()
                    {
                        Nume = nume,
                        Prenume = prenume
                    };
                    context.MecanicSet.Add(mecanic);
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
        /// Return an object of type Mecanic or null if the object is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Mecanic GetById(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

              
                var _mecanic = context.MecanicSet.SingleOrDefault(m => m.Id == id);
                if (_mecanic != null)
                {
                    Mecanic mecanic = new Mecanic()
                    {
                        Id = id
                    };
                    context.MecanicSet.Attach(mecanic);
                    return mecanic;
                }
            }
            return null;
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

                Mecanic mecanic = new Mecanic()
                {
                    Id = id
                };

                context.MecanicSet.Attach(mecanic);
                context.MecanicSet.Remove(mecanic);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Update method. Requires <paramref name="id"/> of the entity Mecanic and 
        /// the new values for <paramref name="nume"/> and <paramref name="prenume"/> to be changed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nume"></param>
        /// <param name="prenume"></param>
        public static void Update(int id, string nume, string prenume)
        {
            Mecanic mecanic = new Mecanic()
            {
                Id = id,
                Nume = nume,
                Prenume = prenume
            };

            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();
                var result = context.MecanicSet.SingleOrDefault(m => m.Id == id);
                if (result != null)
                {
                    result.Nume = nume;
                    result.Prenume = prenume;
                    context.SaveChanges();
                }

            }
        }
        

    }
}
