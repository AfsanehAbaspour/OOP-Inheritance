using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadrTools.Utility
{
    /// <summary>
    /// این کلاس حاوی متد هایی برای عملیات ساده ریاضی است
    /// </summary>
    public static class BasicMathOperatin
    {
        // LedgerCode
        // SubLedgerCode

        /// <summary>
        /// این متد دو عدد صحیح را با هم جمع میکند
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns>مجموع دو عدد صحیح</returns>
        public static int DoSum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        /// <summary>
        /// این متد دو عدد صحیح را از هم کم میکند
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns>تفریق دو عدد صحیح</returns>
        public static int DoSub(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>
        /// این متد دو عدد صحیح را در هم ضرب میکند
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns>ضرب دو عدد صحیح</returns>
        public static int DoMul(int number1, int number2)
        {
            return number1 * number2;

        }

        /// <summary>
        /// این متد دو عدد صحیح را بر هم تقسیم میکند
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns>خارج قسمت دو عدد صحیح</returns>
        public static double DoDiv(int number1, int number2)
        {
            return (double)number1 / number2;
        }


        // 5! = 5*4*3*2*1 

        // 5! = 5*4!

        public static ulong CalculateFactorial(byte number)
        {
            ulong result = 1;

            for (byte i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }



        //System.StackOverflowException:
        //'Exception of type 'System.StackOverflowException' was thrown.'

        // Stack : پشته
        // FILO , LIFO

        // 

        public static ulong CalculateFactorial_Recursive(byte number)
        {
            if (number < 2)
                return 1;
            else
                return number * CalculateFactorial_Recursive((byte)(number - 1));
        }

        public static ulong CalculateFactorial_Recursive2(byte number)
        {
            if (number < 2)
                return 1;
            return number * CalculateFactorial_Recursive2((byte)(number - 1));
        }
    }
}
