using System;
using System.Globalization;

namespace AlphaVantage.Net.Common.Parsing
{
    public static class ParsingExtensions
    {
        public static decimal ParseToDecimal(this string stringToParse)
        {
            return decimal.Parse(stringToParse, CultureInfo.InvariantCulture);
        }
        
        public static DateTime ParseToDateTime(this string stringToParse)
        {
            return DateTime.Parse(stringToParse, CultureInfo.InvariantCulture);
        }
        
        public static long ParseToLong(this string stringToParse)
        {
            return long.Parse(stringToParse, CultureInfo.InvariantCulture);
        }
        
        public static int ParseToInt(this string stringToParse)
        {
            return int.Parse(stringToParse, CultureInfo.InvariantCulture);
        }
    }
}