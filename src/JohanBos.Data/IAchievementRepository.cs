using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Models;

namespace JohanBos.Data
{
    public interface IAchievementRepository
    {
        Task<IEnumerable<Achievement>> GetAll();
    }
}
