namespace PetFamily.Domain.Models.Pets;

public class Address
{
    public Guid Id { get; set; }

    public string Country { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string? Postcode { get; set; }
}