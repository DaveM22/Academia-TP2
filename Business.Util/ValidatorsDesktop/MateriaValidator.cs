using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.ValidatorsDesktop
{
    public class MateriaValidator : AbstractValidator<Materia>
    {
        public MateriaValidator()
        {
            RuleFor(x => x.Descripcion).NotEmpty().WithMessage("El campo descripción es requerido");
            RuleFor(x => x.HSSemanales).Must(x => x > 0).WithMessage("El campo horas semanales debe ser mayor a 0");
            RuleFor(x => x.HSTotales).Must(x => x > 0).WithMessage("El campo horas totales debe ser mayor a 0");
        }
    }
}
