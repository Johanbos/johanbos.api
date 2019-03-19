using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;
using JohanBos.Data;

namespace JohanBos.Data.Json
{
    public class BioRepository : IBioRepository
    {
        public async Task<Bio> GetBio()
        {
            var content = await Data.GetResource("Bio").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<Bio>(content);
        }
    }
}