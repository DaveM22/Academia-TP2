using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Business.Util.ValidatorsDesktop
{
    public class EspecialidadValidator: AbstractValidator<Especialidad>
    {
        public EspecialidadValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("El campo descripción es obligatorio");
        }
    }
}
