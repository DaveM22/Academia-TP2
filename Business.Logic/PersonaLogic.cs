using Business.Data;
using Business.Entities;
using Business.Entities.Enums;
using Business.Util.Exceptions;
using System;
using System.Collections.Generic;

namespace Business.Logic
{
    public class PersonaLogic
    {
        private PersonaAdapter PersonaData => new();

        public List<Persona> GetPersonas(TipoPersonaEnum tipoPersona)
        {
            return PersonaData.GetPersonas(tipoPersona);
        }

        public Persona GetOne(int id)
        {
            return PersonaData.GetOne(id);
        }

        public List<Persona> GetPersonasForUsuarios(TipoPersonaEnum tipoPersona)
        {
            return PersonaData.GetPersonasForUsuarios(tipoPersona);
        }

        public Persona Save(Persona persona)
        {
            return PersonaData.Save(persona);
        }

        public void Delete(Persona persona)
        {
            if (PersonaData.ExistPersonaCF(persona.Id))
            {
                throw new DeleteCFReferenciadaException("La persona esta vinculada a inscripciones o asignacion de docente a un curso. Debera borrar todas las asignaciones vinculadas a la persona para poder borrarla");
            }
            PersonaData.Delete(persona);
        }

        public List<Persona> DocentesByPlanForCurso(List<int> idsProfesor)
        {
            return PersonaData.DocentesByPlanForCurso(idsProfesor);
        }
    }
}
