using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService
{
    /// <summary>
    /// Class <see cref="Images"/> manages objects of type <see cref="Imagine"/>
    /// </summary>
    public class Images
    {
        /// <summary>
        /// Adds a new object of type <see cref="Imagine"/>
        /// </summary>
        /// <param name="titlu"></param>
        /// <param name="descriere"></param>
        /// <param name="data"></param>
        /// <param name="photo"></param>
        /// <param name="detaliuCmdId"></param>
        public static void Add(string titlu, string descriere, DateTime data, byte[] photo, int detaliuCmdId)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                try
                {
                    Imagine imagine = new Imagine()
                    {
                        Titlu = titlu,
                        Descriere = descriere,
                        Data = data,
                        Photo = photo,
                        DetaliuComandaId = detaliuCmdId
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
        /// Deletes an object of type <see cref="Imagine"/>
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(int id)
        {
            using (ModelCarServiceContainer context = new ModelCarServiceContainer())
            {
                context.Database.Connection.Open();

                Imagine imagine = new Imagine()
                {
                    Id = id
                };

                context.ImagineSet.Attach(imagine);
                context.ImagineSet.Remove(imagine);
                context.SaveChanges();
            }
        }
    }
}
