using Microsoft.AspNetCore.Mvc;
using PetFamily.Domain.Shared.ValueObjects;
using PetFamily.Domain.SpeciesAggregate;

namespace PetFamily.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController
{
    [HttpGet]
    public List<Species> Get()
    {
        var species = new List<Species>();
        species.AddRange(new[]
        {
            new Species(Name.Create("test").Value),
            new Species(Name.Create("name2").Value),
            new Species(Name.Create("name3").Value),
            new Species(Name.Create("name4").Value),
            new Species(Name.Create("name5").Value),
            new Species(Name.Create("name6").Value)
        });
        return species;
    }
}