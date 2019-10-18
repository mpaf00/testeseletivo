namespace ApiDois.Test
{
    using Microsoft.AspNetCore.Mvc.Testing;
    using System.Net.Http;

    public class BaseIntegrationTest
    {
        protected readonly HttpClient TestClient;

        public BaseIntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();

            TestClient = appFactory.CreateClient();
        }
    }
}
