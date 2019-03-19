using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Models;

namespace JohanBos.Data
{
    public interface IBioRepository
    {
        Task<Bio> GetBio();
    }
}
