using PetFamily.Application.VolunteerAggregate.Commands.Pet.ChangePetsPosition;

namespace PetFamily.API.Contracts.Pet;

public record ChangePetsPositionRequest(int NewPosition)
{
    public ChangePetsPositionCommand ToCommand(Guid volunteerId, Guid petId)
    {
        return new ChangePetsPositionCommand(volunteerId, petId, NewPosition);
    }
}