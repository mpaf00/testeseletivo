namespace ApiDois.Controllers
{
    using ApiDois.Util;
    using Microsoft.AspNetCore.Mvc;

    public class ShowMeTheCodeController : BaseController
    {
        [HttpGet]
        public string Get()
        {
            return Constant.GetUrlCodigoFonte();
        }
    }
}
