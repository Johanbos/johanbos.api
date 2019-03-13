using System.Collections.Generic;
using System.Threading.Tasks;
using JohanBos.Services.Interfaces;
using JohanBos.Data;
using JohanBos.Models;
using System;

namespace JohanBos.Services
{
    public class HistoryService : IHistoryService
    {
        private readonly IAchievementRepository achievementRepository;
        private readonly IEmployerRepository employerRepository;

        public HistoryService(IAchievementRepository achievementRepository, IEmployerRepository employerRepository)
        {
            this.achievementRepository = achievementRepository ?? throw new ArgumentNullException(nameof(achievementRepository));
            this.employerRepository = employerRepository ?? throw new ArgumentNullException(nameof(employerRepository));
        }

        public Task<IEnumerable<Achievement>> GetAllAchievements()
        {
            return achievementRepository.GetAll();
        }

        public Task<IEnumerable<Employer>> GetAllEmployers()
        {
            return employerRepository.GetAll();
        }
    }
}