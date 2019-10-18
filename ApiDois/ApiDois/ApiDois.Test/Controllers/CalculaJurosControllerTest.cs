namespace ApiDois.Test.Controllers
{
    using ApiDois.Extension;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Net;
    using System.Threading.Tasks;

    [TestClass]
    public class CalculaJurosControllerTest : BaseIntegrationTest
    {
        [TestMethod]
        public async Task GetValorFinal()
        {
            var response = await TestClient.GetAsync("calculajuros?valorinicial=100&meses=5");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("105,10", await response.Content.ReadAsStringAsync());
        }

        [TestMethod]
        public void CalculaJuros()
        {
            double valorInicial = 100;
            var meses = 5;

            var valorFinal = valorInicial.CalculaJuros(meses, true);

            Assert.AreEqual(105.10, valorFinal);
        }

        [TestMethod]
        public void MesMenorQueZero()
        {
            double valorInicial = 100;
            var meses = -1;

            var valorFinal = valorInicial.CalculaJuros(meses, true);

            Assert.AreEqual(0, valorFinal);
        }

        [TestMethod]
        public void ValorInicialMenorQueZero()
        {
            double valorInicial = -100;
            var meses = 5;

            var valorFinal = valorInicial.CalculaJuros(meses, true);

            Assert.AreEqual(0, valorFinal);
        }
    }
}
