using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;
using Newtonsoft.Json;

namespace JohanBos.Data.Json
{
    public class EmployerRepository : IEmployerRepository
    {
        public async Task<IEnumerable<Employer>> GetAll()
        {
            var content = await Data.GetResource("Employers").ConfigureAwait(false);
            return JsonConvert.DeserializeObject<IEnumerable<Employer>>(content);
        }
    }
}