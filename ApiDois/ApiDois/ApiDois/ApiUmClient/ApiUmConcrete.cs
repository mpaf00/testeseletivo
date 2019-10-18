namespace ApiDois.ApiUmClient
{
    using ApiDois.Exception;
    using ApiDois.Extension;
    using ApiDois.Util;
    using System;
    using System.Net.Http;

    public class ApiUmConcrete : IApiUm
    {
        public double GetTaxaJuros()
        {
            double taxaJuros = 0;

            try
            {
                using var httpClient = new HttpClient();
                var url = string.Format("{0}/taxaJuros", Constant.GetUrlApiUm());
                var json = httpClient.GetStringAsync(url).Result;

                json = json.Replace("\"", string.Empty);

                taxaJuros = json.ConvertToDouble();
            }
            catch (Exception e)
            {
                ExceptionHelper.DealingException(e);
            }

            return taxaJuros;
        }
    }
}
