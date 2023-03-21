using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckScale.Library.Data.DBContext;

namespace TruckScale.Library.Data.Data_Layer
{
    public class DataLayer
    {
        private ScaleDbContext dbContext;
        public DataLayer()
        {
            dbContext = new ScaleDbContext();
        }


    }
}
