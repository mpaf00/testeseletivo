namespace ApiUm.Test.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Net;
    using System.Threading.Tasks;

    [TestClass]
    public class TaxaJurosControllerTest : BaseIntegrationTest
    {
        [TestMethod]
        public async Task GetTaxaJuros()
        {
            var response = await TestClient.GetAsync("taxaJuros");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("0,01", await response.Content.ReadAsStringAsync());
        }
    }
}
