namespace Dotnetos.Conference.WebApi.Entities
{
    public record OnlineSpeaker(string FirstName, string LastName, string Company, bool OnlineSetupTested) : Speaker(FirstName, LastName, Company);
}