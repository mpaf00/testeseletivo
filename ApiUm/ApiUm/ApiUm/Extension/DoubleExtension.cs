namespace ApiUm.Extension
{
    using ApiUm.Util;
    using System;

    public static class DoubleExtension
    {
        public static string FormatToPtBR(this double input)
        {
            var value = input.ToString("G", Constant.GetCultureInfo());

            return value;
        }

        public static string FormatToMoneyPtBR(this double input)
        {
            var value = string.Format(Constant.GetCultureInfo(), "{0:0.00}", input);

            return value;
        }

        public static double ConvertToDouble(this string input)
        {
            var value = Convert.ToDouble(input, Constant.GetCultureInfo().NumberFormat);

            return value;
        }
    }
}
