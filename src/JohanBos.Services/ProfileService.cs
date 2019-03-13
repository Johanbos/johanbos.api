using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Data;
using JohanBos.Services.Interfaces;
using JohanBos.Models;
using System;

namespace JohanBos.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IPassionAreaRepository passionAreaRepository;

        public ProfileService(IPassionAreaRepository passionAreaRepository)
        {
            this.passionAreaRepository = passionAreaRepository ?? throw new ArgumentNullException(nameof(passionAreaRepository));
        }

        public Task<IEnumerable<PassionArea>> GetAllPassionAreas()
        {
            return passionAreaRepository.GetAll();
        }
    }
}