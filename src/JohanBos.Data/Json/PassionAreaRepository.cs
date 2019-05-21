using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;

namespace JohanBos.Data.Json
{
    public class PassionAreaRepository : IPassionAreaRepository
    {
        public async Task<IEnumerable<PassionArea>> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://johanbos.github.io/interests.json");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<PassionArea>>(content);
            }
        }
    }
}