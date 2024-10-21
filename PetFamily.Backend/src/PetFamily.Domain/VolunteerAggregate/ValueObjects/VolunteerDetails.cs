namespace PetFamily.Domain.VolunteerAggregate.ValueObjects;

public record VolunteerDetails
{
    private readonly List<SocialNetwork> _socialNetworks = [];
    private readonly List<Requisite> _requisites = [];

    //ef core
    private VolunteerDetails()
    {
    }

    public VolunteerDetails(IEnumerable<SocialNetwork>? socialNetworks, IEnumerable<Requisite>? requisites)
    {
        if (socialNetworks is not null) _socialNetworks.AddRange(socialNetworks);
        if (requisites is not null) _requisites.AddRange(requisites);
    }

    public IReadOnlyList<SocialNetwork> SocialNetworks => _socialNetworks.AsReadOnly();
    public IReadOnlyList<Requisite> Requisites => _requisites.AsReadOnly();
}