using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using JohanBos.Models;

namespace JohanBos.Data.Interfaces
{
    public interface IEmployerRepository
    {
        Task<IEnumerable<Employer>> GetAll();
    }
}
