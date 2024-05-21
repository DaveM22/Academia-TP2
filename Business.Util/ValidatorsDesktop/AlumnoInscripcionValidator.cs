using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.ValidatorsDesktop
{
    public class AlumnoInscripcionValidator : AbstractValidator<AlumnoInscripcion>
    {
        public AlumnoInscripcionValidator() 
        {
            RuleFor(x => x.Nota).Must(x => x.Value >= 6 && x.Value <= 10).WithMessage("Debe ser asignarse una nota mayor igual 6 y menor igual a 10");
        }
    }
}
