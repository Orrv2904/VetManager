using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace VetManager
{
    public class RegisterViewModel : AbstractValidator<RegisterViewModel>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasena { get; set; }

        public RegisterViewModel()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es requerido");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("El apellido es requerido");
            RuleFor(x => x.CorreoElectronico).NotEmpty().WithMessage("El correo electrónico es requerido");
            RuleFor(x => x.Contrasena).NotEmpty().WithMessage("La contraseña es requerida");
        }
    }
}
