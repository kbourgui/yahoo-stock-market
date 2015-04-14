using System;
using System.Globalization;

namespace YSQ.core.DataTypeConverter
{
    public class DateFormat
    {
        public static DateTime? GetDate(string value)
        {
            DateTime result;

            //Try parsing in the current culture
            if (!DateTime.TryParse(value, CultureInfo.CurrentCulture, DateTimeStyles.None, out result) &&
                //Then try in US english
                !DateTime.TryParse(value, CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None, out result) &&
                //Then in neutral language
                !DateTime.TryParse(value, CultureInfo.InvariantCulture, DateTimeStyles.None, out result) &&
                !DateTime.TryParse(value, out result))
            {
                if (string.IsNullOrEmpty(value)) return null;

                throw new FormatException(string.Format("Cannot parse {0} value to DateTime.", value));
            }

            return result;
        }
    }
}
