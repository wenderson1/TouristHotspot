using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristHotspot.Application.Commands.CreateTourSpot;

namespace TouristHotspot.Application.Validators
{
    public class CreateTourSpotCommandValidator:AbstractValidator<CreateTourSpotCommand>
    {
        public CreateTourSpotCommandValidator()
        {
            RuleFor(ts => ts.Name)
                .MaximumLength(100)
                .MinimumLength(2)
                .WithMessage("Nome deve ser no mínimo de 2 caracteres e máximo de 100");

            RuleFor(ts => ts.Description)
                .MaximumLength(100)
                .MinimumLength(2)
                .WithMessage("Descrição deve ser no mínimo de 2 caracteres e máximo de 100");

            RuleFor(ts => ts.State)
                .MaximumLength(2)
                .MinimumLength(2)
                .WithMessage("Estado precisa ter 2 caracteres");
        }
    }
}
