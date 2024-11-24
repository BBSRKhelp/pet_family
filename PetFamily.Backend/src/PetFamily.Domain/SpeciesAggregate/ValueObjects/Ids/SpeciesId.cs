using System.Runtime.InteropServices;

namespace PetFamily.Domain.SpeciesAggregate.ValueObjects.Ids;

public record SpeciesId
{
    private SpeciesId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }
    
    public static SpeciesId NewId() => new(Guid.NewGuid());
    public static SpeciesId Empty() => new(Guid.Empty);
    public static SpeciesId Create(Guid id) => new(id);
    
    public static implicit operator Guid(SpeciesId id) => id.Value;
    public static implicit operator SpeciesId(Guid id) => SpeciesId.Create(id);
}