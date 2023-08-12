using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.ValidatorsDesktop
{
    public class ComisionValidator : AbstractValidator<Comision>
    {
        public ComisionValidator() 
        {
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("El campo Descripción es obligatorio");
            RuleFor(x => x.AnioEspecialidad).Must(x => x > 0).WithMessage("El campo Año especialidad debe ser mayor a cero");
            RuleFor(x => x.PlanId).Must(x => x > 0).WithMessage("El campo plan es obligatorio");
        }
    }
}
