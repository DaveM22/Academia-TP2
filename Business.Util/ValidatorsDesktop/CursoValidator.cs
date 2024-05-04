using Business.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Util.ValidatorsDesktop
{
    public class CursoValidator : AbstractValidator<Curso>
    {
        public CursoValidator()
        {
            
            RuleFor(x => x.ComisionId).Must(x => x > 0).WithMessage("El campo comisión es obligatorio");
            RuleFor(x => x.MateriaId).Must(x => x > 0).WithMessage("El campo materia es obligatorio");
            RuleFor(x => x.Cupo).Must(x => x > 0).WithMessage("El campo cupo debe ser un valor mayor a cero");
            RuleFor(x => x.AnioCalendario).Must(x => x > 0).WithMessage("El campo año calendario no admite valores menores a cero");
        }
    }
}
