using Business.Entities;
using Business.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace Business.Data
{
    public class PersonaAdapter
    {
        public List<Persona> GetPersonas(TipoPersonaEnum tipoPersona)
        {
            using var context = new AcademiaContext();
            return context.Personas.Include(x => x.Plan).Where(x => x.TipoPersona == tipoPersona).ToList();
        }

        public List<Persona> GetPersonasForUsuarios(TipoPersonaEnum tipoPersona)
        {
            using var context = new AcademiaContext();
            return context.Personas.Include(x => x.Plan).Include(x => x.Usuario).Where(x => x.TipoPersona == tipoPersona && x.Usuario == null).ToList();
        }

        public Persona GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Personas.Include(x => x.Plan).SingleOrDefault(x => x.Id == id);
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


        //Devuelve los profesores que no esten inscriptos en el curso y que sean del mismo plan
        public List<Persona> DocentesByPlanForCurso(List<int> idsProfesor) 
        {
            using var context = new AcademiaContext();
            return context.Personas.Where(x => TipoPersonaEnum.PROFESOR == x.TipoPersona && !idsProfesor.Contains(x.Id)).ToList();
        }
    }
}
