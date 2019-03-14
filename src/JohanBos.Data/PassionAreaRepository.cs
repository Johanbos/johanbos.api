using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Data.Interfaces;
using JohanBos.Models;
using Newtonsoft.Json;

namespace JohanBos.Data
{
    public class PassionAreaRepository : IPassionAreaRepository
    {
        public async Task<IEnumerable<PassionArea>> GetAll()
        {
            var content = await Data.GetResource("PassionAreas");
            return JsonConvert.DeserializeObject<IEnumerable<PassionArea>>(content);
        }
    }
}