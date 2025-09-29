using System.Net;

public class PetProxy
{
    const string baseUrl = "https://petstore.swagger.io/v2";
    static HttpClient client = new HttpClient();

    static public async Task<string> GetPet(int id) 
    { 
        string pet = string.Empty;
        // Call rest api to get the pet
        HttpResponseMessage response = await client.GetAsync( $"{baseUrl}/pet/{id}");

        // Handle the case where the response is not HTTP OK
        if (response.StatusCode != HttpStatusCode.OK) 
        {
            string errorMessage = $"Bad news :-( There was an error trying to the the pet with id {id}. The status code returned was: {response.StatusCode}";
            Console.WriteLine(errorMessage);
            throw new Exception(errorMessage);
        }

        pet = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"Found and returned the pet with id {id}");
        return pet;
    }

}