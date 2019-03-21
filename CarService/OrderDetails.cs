using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Manages <see cref="DetaliuComanda"/>
    /// </summary>
    public class OrderDetails
    {
        /// <summary>
        /// Adds a new object of type <see cref="DetaliuComanda"/>
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="materialId"></param>
        /// <param name="operatieId"></param>
        /// <param name="mecanicId"></param>
        /// <param name="imagineId"></param>
        public static void Add(int orderId, int materialId, int operatieId, int mecanicId, int? imagineId = null)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                try
                {
                    DetaliuComanda detaliuComanda = new DetaliuComanda()
                    {
                        ComandaId = orderId,
                        MaterialId = materialId,
                        OperatieId = operatieId,
                        MecanicId = mecanicId
                      
                    };
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
        /// Return an object of type <see cref="DetaliuComanda"/> or <code>null</code> if the object is not found
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DetaliuComanda GetById(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();


                var _detaliuCmd = context.MecanicSet.SingleOrDefault(m => m.Id == id);
                if (_detaliuCmd != null)
                {
                    DetaliuComanda detaliuComanda = new DetaliuComanda()
                    {
                        Id = id
                    };
                    context.DetaliuComandaSet.Attach(detaliuComanda);
                    return detaliuComanda;
                }
            }
            return null;
        }

        /// <summary>
        /// Deletes an object of type <see cref="DetaliuComanda"/>
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                DetaliuComanda detaliu = new DetaliuComanda()
                {
                    Id = id
                };

                context.DetaliuComandaSet.Attach(detaliu);
                context.DetaliuComandaSet.Remove(detaliu);
                context.SaveChanges();
            }
        }
    }
}
