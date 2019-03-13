using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Models;

namespace JohanBos.Services.Interfaces
{
    public interface IHistoryService
    {
        Task<IEnumerable<Achievement>> GetAllAchievements();
        Task<IEnumerable<Employer>> GetAllEmployers();
    }
}
