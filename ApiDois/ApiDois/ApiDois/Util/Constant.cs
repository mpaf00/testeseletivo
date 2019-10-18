namespace ApiDois.Util
{
    using System.Globalization;

    public static class Constant
    {
        private static CultureInfo cultureInfo;

        private static string urlApiUm;

        private static string urlCodigoFonte;

        public static CultureInfo GetCultureInfo()
        {
            if (cultureInfo == null)
            {
                cultureInfo = new CultureInfo("pt-BR");
            }

            return cultureInfo;
        }

        public static string GetUrlApiUm()
        {
            if (string.IsNullOrEmpty(urlApiUm))
            {
                urlApiUm = "http://172.17.0.2";
            }

            return urlApiUm;
        }

        public static string GetUrlCodigoFonte()
        {
            if (string.IsNullOrEmpty(urlCodigoFonte))
            {
                urlCodigoFonte = "https://github.com/mpaf00/testeseletivo";
            }

            return urlCodigoFonte;
        }
    }
}
