using FluentValidation;
using PetFamily.Application.Validation;
using PetFamily.Domain.Shared.Models;

namespace PetFamily.Application.VolunteerAggregate.Commands.Pet.HardDeletePet;

public class HardDeletePetCommandValidator : AbstractValidator<HardDeletePetCommand>
{
    public HardDeletePetCommandValidator()
    {
        RuleFor(sd => sd.VolunteerId).NotEmpty().WithError(Errors.General.IsRequired("VolunteerId"));
        
        RuleFor(sd => sd.PetId).NotEmpty().WithError(Errors.General.IsRequired("PetId"));
    }
}