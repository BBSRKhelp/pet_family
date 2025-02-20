using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using PetFamily.Application.Interfaces.Abstractions;
using PetFamily.Application.VolunteerAggregate.Commands.Pet.SetMainPetPhoto;
using PetFamily.Domain.VolunteerAggregate.ValueObjects;

namespace PetFamily.Application.IntegrationTests.Pet.SetMainPetPhotoTests;

public class SetMainPetPhotoTests : PetTestsBase
{
    private readonly ICommandHandler<Guid, SetMainPetPhotoCommand> _sut;
    
    public SetMainPetPhotoTests(PetTestsWebFactory factory) : base(factory)
    {
        _sut = Scope.ServiceProvider.GetRequiredService<ICommandHandler<Guid, SetMainPetPhotoCommand>>();
    }

    [Fact]
    public async Task SetMainPetPhoto_ShouldReturnGuid()
    {
        //Arrange
        var volunteer = await SeedVolunteerAsync();
        var species = await SeedSpeciesAsync();
        var breedId = await SeedBreedAsync(species);
        var pet = await SeedPetAsync(volunteer, species.Id, breedId);

        var petPhoto = new PetPhoto(PhotoPath.Create("123").Value, false);
        pet.AddPhotos([petPhoto]);
        
        var command = new SetMainPetPhotoCommand(volunteer.Id.Value, pet.Id.Value, petPhoto.PhotoPath.Path);
        
        //Act
        var result = await _sut.HandleAsync(command);

        //Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeEmpty();
        result.Value.Should().Be(pet.Id.Value);
        
        var petPhotoFromDb = WriteDbContext
            .Volunteers.FirstOrDefault()
            ?.Pets.FirstOrDefault()
            ?.PetPhotos.FirstOrDefault();
        
        petPhotoFromDb?.IsMainPhoto.Should().BeTrue();
    }

    [Fact]
    public async Task SetMainPetPhoto_WhenVolunteerIdIsInvalid_ShouldReturnFailedResult()
    {
        //Arrange
        var volunteer = await SeedVolunteerAsync();
        var species = await SeedSpeciesAsync();
        var breedId = await SeedBreedAsync(species);
        var pet = await SeedPetAsync(volunteer, species.Id, breedId);

        var petPhoto = new PetPhoto(PhotoPath.Create("123").Value, false);
        pet.AddPhotos([petPhoto]);
        
        var command = new SetMainPetPhotoCommand(Guid.Empty, pet.Id.Value, petPhoto.PhotoPath.Path);
        
        //Act
        var result = await _sut.HandleAsync(command);

        //Assert
        result.IsFailure.Should().BeTrue();
        result.Error.Should().NotBeNull();
    }
}