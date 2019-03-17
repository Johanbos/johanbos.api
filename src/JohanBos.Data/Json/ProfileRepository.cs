using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;
using JohanBos.Data;

namespace JohanBos.Data.Json
{
    public class ProfileRepository : IProfileRepository
    {
        public async Task<Profile> GetOne()
        {
            var content = await Data.GetResource("Profile").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<Profile>(content);
        }
    }
}