using Dotnetos.Conference.WebApi.Entities;
using Dotnetos.Conference.WebApi.Models;

namespace Dotnetos.Conference.WebApi
{
    public class Mapper
    {
        public SpeakerDTO ToDto(Speaker speaker) => new(speaker.FirstName, speaker.LastName, speaker.Company, speaker is OnlineSpeaker);
    }
}