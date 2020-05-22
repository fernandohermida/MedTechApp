using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedTechApp.Application.Patients.Commands.CreatePatientCommand
{
    class CreatePatientCommandValidator : AbstractValidator<CreatePatientCommand>
    {
        public CreatePatientCommandValidator()
        {
            RuleFor(v => v.FirstName)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}
