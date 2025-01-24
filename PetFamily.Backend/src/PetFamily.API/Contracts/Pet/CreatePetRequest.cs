using PetFamily.Application.DTOs;
using PetFamily.Application.DTOs.Pet;
using PetFamily.Application.VolunteerAggregate.Commands.AddPet;
using PetFamily.Domain.VolunteerAggregate.Enums;

namespace PetFamily.API.Contracts.Pet;

public record CreatePetRequest(
    string Name,
    string Description,
    Colour Colouration,
    float Weight,
    float Height,
    string HealthInformation,
    bool IsCastrated,
    bool IsVaccinated,
    string Country,
    string City,
    string Street,
    string? Postalcode,
    string PhoneNumber,
    DateOnly? Birthday,
    StatusForHelp Status,
    IEnumerable<RequisiteDto>? Requisites,
    Guid SpeciesId,
    Guid BreedId)
{
    public AddPetCommand ToCommand(Guid volunteerId)
    {
        var appearanceDetails = new AppearanceDetailsDto(Colouration, Weight, Height);
        
        var healthDetails = new HealthDetailsDto(HealthInformation, IsCastrated, IsVaccinated);
        
        var address = new AddressDto(Country, City, Street, Postalcode);
        
        var breedAndSpeciesId = new BreedAndSpeciesIdDto(
            Domain.SpeciesAggregate.ValueObjects.Ids.SpeciesId.Create(SpeciesId), 
            BreedId);
        
        return new AddPetCommand(
            volunteerId,
            Name,
            Description,
            appearanceDetails,
            healthDetails,
            address,
            PhoneNumber,
            Birthday,
            Status,
            Requisites,
            breedAndSpeciesId);
    }
}