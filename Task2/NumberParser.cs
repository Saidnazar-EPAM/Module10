using System;
using System.Text.RegularExpressions;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if(stringValue == null)
            {
                throw new ArgumentNullException(nameof(stringValue));
            }
            stringValue = stringValue.Trim();
            var match = new Regex(@"^[\+-]?\d+$");
            if (!match.IsMatch(stringValue))
            {
                throw new FormatException();
            }
            int result = 0;
            char sign = '0';
            if(!Char.IsDigit(stringValue[0]))
            {
                sign = stringValue[0];
                stringValue = stringValue.Remove(0, 1);
            }
            if(sign == '+' || sign == '0')
            {
                foreach (char c in stringValue)
                {
                    result = checked(result * 10);
                    result = checked(result + (c - '0'));
                }
            }
            else
            {
                foreach (char c in stringValue)
                {
                    result = checked(result * 10);
                    result = checked(result - (c - '0'));
                }
            }
            return result;
        }
    }
}