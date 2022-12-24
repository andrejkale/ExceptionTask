using System.Text.RegularExpressions;

namespace ExceptionTask
{
    public class Parser
    {
        public static double ParseRealNumber(string parsingString, string separator)
        {
            double result = 0.0;
            string substring = Regex.Match(parsingString, @"\d+\.*\d*").Value;
            if (!substring.Equals(""))
            {
                result = double.Parse(substring, new System.Globalization.NumberFormatInfo
                {
                    NumberDecimalSeparator = separator
                });
            } else
            {
                throw new NumberCanNotBeParsedException(parsingString);
            }
            
            return result;
        }
    }
}
