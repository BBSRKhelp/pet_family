using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetFamily.Application.Interfaces.Abstractions;
using PetFamily.Application.VolunteerAggregate.Commands.Volunteer.Create;

namespace PetFamily.Application.IntegrationTests.Volunteer.CreateVolunteerTests;

public class CreateVolunteerTests : VolunteerTestsBase
{
    private readonly ICommandHandler<Guid, CreateVolunteerCommand> _sut;
    
    public CreateVolunteerTests(VolunteerTestsWebFactory factory) : base(factory)
    {
        _sut = Scope.ServiceProvider.GetRequiredService<ICommandHandler<Guid, CreateVolunteerCommand>>();
    }

    [Fact]
    public async Task CreateVolunteer_ShouldReturnGuid()
    {
        //Arrange
        var command = Fixture.BuildCreateVolunteerCommand();
        
        //Act
        var result = await _sut.HandleAsync(command, CancellationToken.None);

        //Assert
        result.IsSuccess.Should().BeTrue();
        result.Value.Should().NotBeEmpty();

        var volunteer = await WriteDbContext.Volunteers.FirstOrDefaultAsync();

        volunteer.Should().NotBeNull();
        volunteer.Id.Value.GetType().Should().Be(typeof(Guid));
    }
}