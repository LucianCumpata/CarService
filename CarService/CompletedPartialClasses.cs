using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarService
{
    public partial class Client
    {
        public bool AddClient()
        {
            using (ModelCarServiceContainer ctx = new ModelCarServiceContainer())
            {
                bool bResult = false;
                if (this.Id == 0)
                {
                    var it = ctx.Entry<Client>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }
    }
}
