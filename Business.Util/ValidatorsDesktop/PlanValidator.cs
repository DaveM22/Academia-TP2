using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.ValidatorsDesktop
{
    public class PlanValidator : AbstractValidator<Plan>
    {
        public PlanValidator() 
        {
            RuleFor(x => x.Descripcion).NotNull().NotEmpty().WithMessage("El campo Descripción es obligatorio");
            RuleFor(x => x.EspecialidadId).Must(x => x != 0).WithMessage("El campo Especialidad es obligatorio");
        }
    }
}
