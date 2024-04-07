using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public static class Adapter
    {
        public static AcademiaContext dbContext;




        public static void SetContext(AcademiaContext dbContextt)
        {
            dbContext = dbContextt;
        }
    }
}
