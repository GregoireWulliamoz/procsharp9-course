namespace Dotnetos.Conference.WebApi.Models
{
    public record SpeakerDTO(string FirstName, string LastName, string Company, bool PresentingOnline)
    {
        public override string ToString() => $"{FirstName} {LastName} ({Company}), presenting online: {PresentingOnline}";
    }
}