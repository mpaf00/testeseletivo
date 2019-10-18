namespace ApiDois.Extension
{
    using ApiDois.ApiUmClient;
    using ApiDois.Exception;
    using ApiDois.Util;
    using System;

    public static class DoubleExtension
    {
        public static double ConvertToDouble(this string input)
        {
            var value = Convert.ToDouble(input, Constant.GetCultureInfo().NumberFormat);

            return value;
        }

        public static string FormatToMoneyPtBR(this double input)
        {
            var value = string.Format(Constant.GetCultureInfo(), "{0:0.00}", input);

            return value;
        }

        public static double CalculaJuros(this double valorInicial, int meses, bool mockApi = false)
        {
            double valorFinal = 0;

            try
            {
                if (ValidaParametros(valorInicial, meses))
                {
                    var apiUmHelper = mockApi ? new ApiUmMockConcreteCreator().FactoryMethod() : new ApiUmConcreteCreator().FactoryMethod();

                    double juros = 0;

                    var taxaJuros = apiUmHelper.GetTaxaJuros();

                    juros = 1 + taxaJuros;

                    valorFinal = valorInicial * Math.Pow(juros, meses);

                    valorFinal = Math.Truncate(valorFinal * 100) / 100;
                }
            }
            catch (Exception e)
            {
                ExceptionHelper.DealingException(e);
            }

            return valorFinal;
        }

        private static bool ValidaParametros(double valorInicial, int meses)
        {
            var isValid = true;

            if (valorInicial <= 0)
            {
                isValid = false;
            }

            if (meses < 0)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
