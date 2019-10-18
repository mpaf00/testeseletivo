namespace ApiDois.Controllers
{
    using ApiDois.Extension;
    using Microsoft.AspNetCore.Mvc;

    public class CalculaJurosController : BaseController
    {
        [HttpGet]
        public string Get(double valorinicial, int meses)
        {
            return valorinicial
                    .CalculaJuros(meses)
                    .FormatToMoneyPtBR();
        }
    }
}
