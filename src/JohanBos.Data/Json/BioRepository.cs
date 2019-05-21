using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;
using JohanBos.Data;
using System.Net.Http;

namespace JohanBos.Data.Json
{
    public class BioRepository : IBioRepository
    {
        public async Task<Bio> GetBio()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://johanbos.github.io/bio.json").ConfigureAwait(false);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<Bio>(content);
            }
        }
    }
}