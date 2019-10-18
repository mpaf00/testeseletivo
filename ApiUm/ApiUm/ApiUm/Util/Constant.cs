namespace ApiUm.Util
{
    using System.Globalization;

    public static class Constant
    {
        private static CultureInfo cultureInfo;

        public const double TaxaJuros = 0.01;

        public static CultureInfo GetCultureInfo()
        {
            if (cultureInfo == null)
            {
                cultureInfo = new CultureInfo("pt-BR");
            }

            return cultureInfo;
        }
    }
}
