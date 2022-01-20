using Business.Entities;
using Business.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Data
{
    public class PersonaAdapter
    {
        public List<Persona> GetPersonas(TipoPersonaEnum tipoPersona)
        {
            using var context = new AcademiaContext();
            return context.Personas.Include(x => x.Plan).Where(x => x.TipoPersona == tipoPersona).ToList();
        }
    }
}
