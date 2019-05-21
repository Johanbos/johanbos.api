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
    public class AchievementRepository : IAchievementRepository
    {
        public async Task<IEnumerable<Achievement>> GetAll()
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://johanbos.github.io/achievements.json");
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Achievement>>(content);
            }
        }
    }
}