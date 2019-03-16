using Microsoft.VisualStudio.TestTools.UnitTesting;
using JohanBos.Data;
using JohanBos.Services;
using Moq;

namespace JohanBos.UnitTest
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void TestHistoryServiceCallsRepositories()
        {
            var achievementRepository = new Mock<IAchievementRepository>();
            var employerRepository = new Mock<IEmployerRepository>();
            achievementRepository.Setup(foo => foo.GetAll()).Verifiable();
            employerRepository.Setup(foo => foo.GetAll()).Verifiable();
            var service = new HistoryService(achievementRepository.Object, employerRepository.Object);

            service.GetAllAchievements();
            achievementRepository.Verify();
            service.GetAllEmployers();
            employerRepository.Verify();
        }
    }
}
