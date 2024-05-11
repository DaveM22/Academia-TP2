using Business.Entities;
using FluentValidation;

namespace Business.Util.ValidatorsDesktop
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.NombreUsuario)
                .NotEmpty()
                .WithMessage("El campo nombre de usuario es obligatorio")
                .MinimumLength(4)
                .WithMessage("El campo nombre de usuario debe tener al menos 4 caracteres");
            RuleFor(x => x.Clave)
                .NotEmpty()
                .WithMessage("El campo nombre clave es obligatorio")
                .MinimumLength(4)
                .WithMessage("El campo clave debe tener al menos 4 caracteres");
            RuleFor(x => x.Nombre)
            .NotEmpty()
            .WithMessage("El campo nombre clave es obligatorio")
            .MinimumLength(4)
            .WithMessage("El campo nombre debe tener al menos 4 caracteres");
            RuleFor(x => x.Apellido)
            .NotEmpty()
            .WithMessage("El campo apellido clave es obligatorio")
            .MinimumLength(4)
            .WithMessage("El campo apellido debe tener al menos 4 caracteres");
        }
    }
}
