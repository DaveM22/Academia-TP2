using Business.Data;
using Business.Entities;
using Business.Entities.Enums;
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
            PersonaData.Delete(persona);
        }

        public List<Persona> DocentesByPlanForCurso(List<int> idsProfesor)
        {
            return PersonaData.DocentesByPlanForCurso(idsProfesor);
        }
    }
}
