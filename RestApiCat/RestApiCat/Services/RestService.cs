using RestApiCat.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RestApiCat.Services
{
    public class RestService : IRestService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public CountModel Items { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        Task<List<EntryModel>> IRestService.GetDataAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<EntryModel>> GetDataAsync()
        {
            Items = new CountModel();

            Uri uri = new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Items = JsonSerializer.Deserialize<CountModel>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Items.entries;
        }
    }
}
