using System.Text.Json;
using NoviProject.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;



namespace NoviProject.Services
{

    public class NoviAMSApiService : INoviAMSApiService
    {
        private readonly HttpClient client;

        public NoviAMSApiService(IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient("NoviAMSApiService");
        }

        public async Task<List<Member>> GetMembers()
        {
            var url = string.Format("api//members?pageSize=1000&offset=0");
            var result = new List<Member>();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var stringResponse = await response.Content.ReadAsStringAsync();
                //Convert the whole collection into the invidual objects.
                //The castable objects are in the MemberRecord class.
                var collection = JsonSerializer.Deserialize<MemberRecord>(stringResponse);

                //Retrieve only the desired part of the collection.
                //Results
                result = collection?.Results;

                //TotalCount can be retrieved by calling
                // var count = collection?.TotalCount;
            }
            else
            {
                throw new HttpRequestException(response.ReasonPhrase);
            }

            return result;
        }
    }
}
