using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esdd_layer
{
    public class tesst
    {
       public tesst()
        {
            esddDAL.DatabaseContext db = new esddDAL.DatabaseContext();
            db.Database.CreateIfNotExists();
        }

    }
}
