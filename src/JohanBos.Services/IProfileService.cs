using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Models;

namespace JohanBos.Services
{
    public interface IProfileService
    {
        Task<IEnumerable<PassionArea>> GetAllPassionAreas();
    }
}
