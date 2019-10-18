namespace ApiUm.Controllers
{
    using ApiUm.Extension;
    using ApiUm.Util;
    using Microsoft.AspNetCore.Mvc;

    public class TaxaJurosController : BaseController
    {
        [HttpGet]
        public string Get()
        {
            return Constant.TaxaJuros.FormatToMoneyPtBR();
        }
    }
}
