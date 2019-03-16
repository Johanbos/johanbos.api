using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;
using JohanBos.Data;

namespace JohanBos.Data.Json
{
    public class AchievementRepository : IAchievementRepository
    {
        public async Task<IEnumerable<Achievement>> GetAll()
        {
            var content = await Data.GetResource("Achievements").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Achievement>>(content);
        }
    }
}