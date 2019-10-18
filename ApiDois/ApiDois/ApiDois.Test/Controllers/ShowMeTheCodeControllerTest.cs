namespace ApiDois.Test.Controllers
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Net;
    using System.Threading.Tasks;

    [TestClass]
    public class ShowMeTheCodeControllerTest : BaseIntegrationTest
    {
        [TestMethod]
        public async Task GetTheCode()
        {
            var response = await TestClient.GetAsync("showMeTheCode");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("https://github.com/mpaf00/testeseletivo", await response.Content.ReadAsStringAsync());
        }
    }
}
