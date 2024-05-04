using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.ValidatorsDesktop
{
    public class PersonaValidator : AbstractValidator<Persona>
    {

        public PersonaValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El campo nombre es obligatorio");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("El campo apellido es obligatorio");
            RuleFor(x => x.FechaNacimiento).NotNull().WithMessage("El campo fecha de nacimiento es obligatorio");
            RuleFor(x => x.PlanId).Must(x => x != 0).WithMessage("El campo plan es obligatorio");
        }
    }
}
