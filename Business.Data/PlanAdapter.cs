using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class PlanAdapter
    {
        public List<Plan> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Planes.Include(x => x.Especialidad).ToList();
        }
    }
}
