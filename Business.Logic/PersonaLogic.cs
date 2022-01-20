using Business.Data;
using Business.Entities;
using Business.Util;
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
    }
}
