using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Operations class offers methods for the Operatie entity
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Add method, adds a new operation to the Operatie entity
        /// </summary>
        /// <param name="denumire"></param>
        /// <param name="timpExec"></param>
        public static void Add(string denumire, Decimal timpExec)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                try
                {
                    Operatie operatie = new Operatie()
                    {
                        Denumire = denumire,
                        TimpExecutie = timpExec
                    };

                    context.OperatieSet.Add(operatie);
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
        /// Return an object of type Operatie or null if the object is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Operatie GetById(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();


                var _operatie = context.MecanicSet.SingleOrDefault(o => o.Id == id);
                if (_operatie != null)
                {
                    Operatie operatie = new Operatie()
                    {
                        Id = id
                    };
                    context.OperatieSet.Attach(operatie);
                    return operatie;
                }
            }
            return null;
        }

        /// <summary>
        /// Deletes an object from the DB. It requires the id of the object
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                Operatie operatie = new Operatie()
                {
                    Id = id
                };

                context.OperatieSet.Attach(operatie);
                context.OperatieSet.Remove(operatie);
                context.SaveChanges();
            }
        }
    }
}
