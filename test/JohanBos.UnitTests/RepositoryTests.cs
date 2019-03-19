using Microsoft.VisualStudio.TestTools.UnitTesting;
using JohanBos.Data.Json;
using System.Linq;
using System.Threading.Tasks;

namespace JohanBos.UnitTest
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public async Task TestPassionAreasRepositoryReturnsList()
        {
            var passionAreaRepository = new PassionAreaRepository();
            var actual = await passionAreaRepository.GetAll().ConfigureAwait(false);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }

        [TestMethod]
        public async Task TestAchievementRepositoryReturnsList()
        {
            var achievementsRepository = new AchievementRepository();
            var actual = await achievementsRepository.GetAll().ConfigureAwait(false);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }

        [TestMethod]
        public async Task TestEmployerRepositoryReturnsList()
        {
            var employerRepository = new EmployerRepository();
            var actual = await employerRepository.GetAll().ConfigureAwait(false);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }

        [TestMethod]
        public async Task TestBioRepositoryReturnsOne()
        {
            var bioRepository = new BioRepository();
            var actual = await bioRepository.GetBio().ConfigureAwait(false);
            Assert.IsNotNull(actual);
        }
    }
}
