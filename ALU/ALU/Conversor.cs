using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALU
{
    class Conversor
    {
        public static readonly char[] DIGIT_DICTIONARY = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        /// <summary>
        /// Reverse the specified string.
        /// </summary>
        /// <returns>The reversed string.</returns>
		/// <param name="s">String to be reverted.</param>
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        
        /// <summary>
        /// Converts the digit to decimal.
        /// </summary>
        /// <returns>The decimal value of the digit.</returns>
        /// <param name="digit">Digit.</param>
        public static double ConvertDigitToDecimal(char digit, int digitBase)
        {
            double digitValue = Array.IndexOf(DIGIT_DICTIONARY, digit);
            if (digitValue >= digitBase)
            {
                throw new System.ArgumentException("Digit " + digit + " is not part of the base " + digitBase);
            }

            return digitValue;
        }

        /// <summary>
        /// Coverts the decimal digit to the given base.
        /// </summary>
        /// <returns>The decimal digit in the given base.</returns>
        /// <param name="number">Digit to be converted.</param>
        /// <param name="numberBase">Digit base.</param>
        public static char ConvertDecimalDigitToBase(int number, int numberBase)
        {
            char digit = DIGIT_DICTIONARY[number];
            if (number >= numberBase)
            {
                throw new System.ArgumentException("Digit " + digit + " is not part of the base " + numberBase);
            }

            return digit;
        }

        /// <summary>
        /// Converts the decimal number to the given base.
        /// </summary>
        /// <returns>The number converted to the given base.</returns>
        /// <param name="input">Decimal numbel.</param>
        /// <param name="outputBase">Base to convert the number.</param>
        public static string ConvertDecimalTo(string input, int outputBase)
        {
            if (outputBase == 10) return input;
            string output = "";
            char digit;
            int diff, integerPart;
            double number = double.Parse(input), result;
            int dividend = (int)Math.Truncate(number);
            double coefficient = number - dividend;

            do
            {
                diff = dividend % outputBase;
                digit = ConvertDecimalDigitToBase(diff, outputBase);
                output += digit;
                dividend = dividend / outputBase;
            } while (dividend != 0);

            output = Reverse(output);

            if (coefficient != 0)
            {
                output += ".";
                int precision = 5;
                while (precision != 0 && coefficient != 0)
                {
                    result = coefficient * outputBase;
                    integerPart = (int)Math.Truncate(result);
                    coefficient = result - integerPart;
                    digit = ConvertDecimalDigitToBase(integerPart, outputBase);
                    output += digit;
                    precision--;
                }
            }

            return output;
        }

        /// <summary>
        /// Converts the number to the given base.
        /// </summary>
        /// <returns>The number.</returns>
        /// <param name="input">Number to be converted.</param>
        /// <param name="inputBase">Number's base.</param>
        /// <param name="outputBase">Base to be converted.</param>
        /*
        public static bool[] ConvertNumber(string input)
        {
            double inputNumber = double.Parse(input);
            string convertedNumber = ConvertDecimalTo(input, 2);
            
            bool[] number = new bool[32];

            // Se o numero for negativo o bit de sinal eh 1
            number[0] = inputNumber < 0;
            
        }
        */

        public static bool[] ConvertSringToBool(string value)
        {
            bool[] valueToReturn = new bool[value.Length];

            for(int i = 0; i < value.Length; i++)
            {
                valueToReturn[i] = value[i] == '1';
            }

            return valueToReturn;
        }

        public static string ConvertBoolToString(bool[] value)
        {
            string valueToReturn = "";

            for (int i = 0; i < value.Length; i++)
            {
                valueToReturn += value[i] == true ? '1' : '0';
            }

            return valueToReturn;
        }
    }
}
