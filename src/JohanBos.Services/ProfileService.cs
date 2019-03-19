using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Data;
using JohanBos.Services;
using JohanBos.Models;
using System;

namespace JohanBos.Services
{
    public class BioService : IBioService
    {
        private readonly IBioRepository bioRepository;
        private readonly IPassionAreaRepository passionAreaRepository;

        public BioService(IPassionAreaRepository passionAreaRepository, IBioRepository bioRepository)
        {
            this.bioRepository = bioRepository ?? throw new ArgumentNullException(nameof(bioRepository));
            this.passionAreaRepository = passionAreaRepository ?? throw new ArgumentNullException(nameof(passionAreaRepository));
        }

        public Task<IEnumerable<PassionArea>> GetAllPassionAreas()
        {
            return passionAreaRepository.GetAll();
        }

        public Task<Bio> GetBio()
        {
            return bioRepository.GetBio();
        }
    }
}