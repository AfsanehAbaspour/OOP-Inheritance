using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadrTools.ExtensionMethods
{
    public static class ArrayExt
    {
        internal static string GetString(this string[] words)
        {
            string result = "";
            foreach (string item in words)
            {
                result += item + " ";
            }

            return result.RemoveLastCharacter();
        }

        /// <summary>
        /// نمایش اطلاعات آرایه
        /// </summary>
        /// <param name="numbers">آرایه عددی</param>
        /// <param name="isVertical">آیا عمودی چاپ شود؟</param>
        /// <returns>آیتم های آرایه</returns>
        public static string GetArrayItems(this int[] numbers, bool isVertical = false)
        {
            #region [ Basic ]

            //if (isVertical)
            //{
            //    foreach (int item in numbers)
            //    {
            //        result += item + "\n";
            //    }
            //}
            //else
            //{
            //    foreach (int item in numbers)
            //    {
            //        result += item + ",";
            //    }
            //} 
            #endregion

            string result = "";
            string seprator = isVertical ? "\n" : ",";

            foreach (int item in numbers)
            {
                result += $"{item}{seprator}";
            }

            return result.RemoveLastCharacter();
        }


    }
}
