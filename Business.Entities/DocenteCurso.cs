using Business.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public int CursoId { get; set; }
        public int DocenteId { get; set; }
        public DocenteCargoEnum DocenteCargo { get; set; }
        public Curso Curso { get; set; }
        public Persona Docente { get; set; }
        public string MateriaDescripcion => Curso.Materia.Descripcion;

        public string ComisionDescripcion => Curso.Comision.Descripcion;

        public string DocenteNombre => Docente.Nombre;
        public string DocenteApellido => Docente.Apellido;

        public int DocenteLegajo => Docente.Legajo;

        public string DocenteCargoDescripcion => DocenteCargo.ToString(); 
    }
}
