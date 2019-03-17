using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Data;
using JohanBos.Services;
using JohanBos.Models;
using System;

namespace JohanBos.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository profileRepository;
        private readonly IPassionAreaRepository passionAreaRepository;

        public ProfileService(IPassionAreaRepository passionAreaRepository, IProfileRepository profileRepository)
        {
            this.profileRepository = profileRepository ?? throw new ArgumentNullException(nameof(profileRepository));
            this.passionAreaRepository = passionAreaRepository ?? throw new ArgumentNullException(nameof(passionAreaRepository));
        }

        public Task<IEnumerable<PassionArea>> GetAllPassionAreas()
        {
            return passionAreaRepository.GetAll();
        }

        public Task<Profile> GetProfile()
        {
            return profileRepository.GetOne();
        }
    }
}