using System.Net;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

public class StoreProxy
{
    const string baseUrl = "https://petstore.swagger.io/v2";
    static HttpClient client = new HttpClient();
 
    static public async Task<string> GetOrder(int id)
    {
        string order = string.Empty;

        // Call rest api to get the user based on name
        HttpResponseMessage response = await client.GetAsync( $"{baseUrl}/store/order/{id}");
      
            
    }
}
    







    


    
    