using Microsoft.VisualStudio.TestTools.UnitTesting;
using JohanBos.Data.Interfaces;
using JohanBos.Data;
using Moq;
using System.Linq;
using System.Threading.Tasks;

namespace JohanBos.UnitTest
{
    [TestClass]
    public class RepositoryTests
    {
        [TestMethod]
        public async Task TestPassionAreasRepositoryReturnList()
        {
            var passionAreaRepository = new PassionAreaRepository();
            var actual = await passionAreaRepository.GetAll();
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }
    }
}
