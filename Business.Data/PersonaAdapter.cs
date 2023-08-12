using Business.Entities;
using Business.Entities.Enums;
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

        public Persona GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Personas.SingleOrDefault(x => x.Id == id);
        }

        public Persona Save(Persona persona)
        {
            using var context = new AcademiaContext();
            context.Update(persona);
            context.SaveChanges();
            return persona;
        }

        public void Delete(Persona persona)
        {
            using var context = new AcademiaContext();
            context.Remove(persona);
            context.SaveChanges();
        }
    }
}
