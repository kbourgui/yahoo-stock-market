using System;
using System.Globalization;

namespace YSQ.core.DataTypeConverter
{
    public static class NumberFormat
    {
        public static double GetDouble(string value)
        {
            double result;

            //Try parsing in the current culture
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //Then try in US english
                !double.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //Then in neutral language
                !double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result) &&
                !double.TryParse(value, out result) &&
                !double.TryParse(value.Replace(".", ","), out result) &&
                 !double.TryParse(value.Replace(CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "").Replace(".", ","), NumberStyles.Any, CultureInfo.CurrentCulture, out result))
            {
                if (string.IsNullOrEmpty(value)) return 0;

                throw new FormatException(string.Format("Cannot parse {0} value to double.", value));
            }

            return result;
        }

        public static bool TryGetDouble(string value, out double outDouble)
        {
            double result;
            outDouble = 0;

            //Try parsing in the current culture
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                //Then try in US english
                !double.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                //Then in neutral language
                !double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result) &&
                !double.TryParse(value, out result) &&
                !double.TryParse(value.Replace(".", ","), out result) &&
                !double.TryParse(value.Replace(CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, "").Replace(".", ","), NumberStyles.Any, CultureInfo.CurrentCulture, out result))
            {
                return false;
            }

            outDouble = result;
            return true;
        }
    }
}
