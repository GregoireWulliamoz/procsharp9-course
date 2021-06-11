using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;

// TODO: As a top-level statements exercise, use only this single file to define everything!

if (args.Length != 1)
{
    PrintHelp();
    return;
}

// TODO: utilize https://swapi.dev/ to search for a person with a given name
//       Hint: Use https://swapi.dev/documentation and look for "Searching"
using HttpClient client = new HttpClient();
var requestUri = $"https://swapi.dev/api/people/?search={args[0]}";
var response = await client.GetFromJsonAsync<PersonsDTO>(requestUri);

if (response?.Count != 1)
{
    Console.WriteLine("There is no single answer to your question!");
}
else
{
    var person = response.Results.First();
    Console.WriteLine($"{person.Name} was born {person.Birth_Year}.");
}

// TODO: define PersonDTO and PersonsDTO records to deserialize (only necessary)
//       fields from https://swapi.dev/api/people/?search=... results.

void PrintHelp()
{
    Console.WriteLine("Print help");
}

record PersonsDTO(int Count, IEnumerable<PersonDTO> Results);
record PersonDTO(string Name, string Birth_Year);