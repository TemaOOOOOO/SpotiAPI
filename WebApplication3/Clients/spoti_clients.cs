using Newtonsoft.Json;
using System.Reflection.Metadata;
using WebApplication3.Models;

namespace WebApplication3.Clients
{
    public class spoti_clients
    {
        private static string _address;
        private static string _apikey;
        private static string _apihost;
        private HttpClient _client;
        public spoti_clients()
        {
            _address = constant.Address;
            _apikey = constant.ApiKey;
            _apihost = constant.ApiHost;
            _client = new HttpClient();
            _client.BaseAddress = new Uri(_address);
        }

        public async Task<spoti_tracker> GetArtistAlbums(string singer)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_address.Replace("%q%",singer).Replace("%type%", "albums")),
                Headers =
                {
                { "X-RapidAPI-Key", _apikey },
                { "X-RapidAPI-Host", _apihost },
                },
            };
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

               

                var result = JsonConvert.DeserializeObject<spoti_tracker>(body);

                return result;
            }
        }

        public async Task<spoti_tracker> GetArtist(string artist)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(_address.Replace("%q%", artist).Replace("%type%", "artists")),
                Headers =
                {
                { "X-RapidAPI-Key", _apikey },
                { "X-RapidAPI-Host", _apihost },
                },
            };
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                

                var result = JsonConvert.DeserializeObject<spoti_tracker>(body);

                return result;
            }
        }

    }
}
