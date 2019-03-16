using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;

namespace JohanBos.Data.Json
{
    public class PassionAreaRepository : IPassionAreaRepository
    {
        public async Task<IEnumerable<PassionArea>> GetAll()
        {
            var content = await Data.GetResource("PassionAreas").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<PassionArea>>(content);
        }
    }
}