using System;
using System.Collections.Generic;

namespace SadrTools.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringMethods
    {
        #region [ Public  ]
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetGreetings()
        {
            return "به نرم افزار ما خوش آمدید";
        }

        public static string GetGreetings(string userFullName)
        {
            return userFullName + " عزیز ! به نرم افزار ما خوش آمدید ";
        }


        /// <summary>
        /// تکمیل شود
        /// </summary>
        /// <returns></returns>
        public static string GetTodayText()
        {
            return "امروز ، جمعه به تاریخ سوم دی ماه سال یک هزار و چهارصد شمسی میباشد";
        }


        public static string MakeAbbreviation(string firstName, string lastName)
        {
            return firstName.Substring(0, 1) +
                   "." +
                   lastName.Substring(0, 1);
        }

        public static string MakeAbbreviation(string firstName, string lastName, char seprator)
        {
            return firstName.Substring(0, 1) +
                   seprator +
                   lastName.Substring(0, 1);
        }

        public static string MakeAbbreviation(string firstName, string lastName, char seprator, bool isUpperCase)
        {
            string fn = isUpperCase ? firstName.Substring(0, 1).ToUpper() : firstName.Substring(0, 1);
            string ln = isUpperCase ? lastName[0].ToString().ToUpper() : lastName[0].ToString();
            return fn + seprator + ln;
        }


        public static string MakeAbbreviation(string firstName, string lastName, char seprator, bool isUpperCase, int length = 1)
        {
            //Shima
            //Schima
            //Porsche
            //Schon
            //Bosch
            //Schengen *

            string fn = isUpperCase ? firstName.Substring(0, length).ToUpper() : firstName.Substring(0, length);
            string ln = isUpperCase ? lastName.Substring(0, length).ToUpper() : lastName.Substring(0, length);
            return fn + seprator + ln;

        }

        public static string MakePascal(string sentence)
        {
            // hello my name is soroush sadr

            string[] words = sentence.Split(new char[] { ' ' });
            string newSentence = "";
            foreach (string word in words)
            {
                if (word.Length == 0)
                    continue;

                newSentence += $"{ MakeItPascal(word)},";
            }

            //return newSentence;

            return RemoveLastCharacter(newSentence);
        }

        public static string MakePascal2(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' });

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                    continue;

                words[i] = MakeItPascal(words[i]);
            }

            return ArrayToString(words);

        }

        public static string RemoveLastCharacter(string str)
        {
            return str.Substring(0, str.Length - 1);
        } 
        #endregion

        #region [ متد های کمکی - خصوصی هستند از بیرون دیده نمیشوند ] 
     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        private static string MakeItPascal(string word)
        {
            return word.Substring(0, 1).ToUpper() +
                   word.Substring(1).ToLower();
        }

        internal static string ArrayToString(string[] words)
        {
            string result = "";
            foreach (string item in words)
            {
                result += item + " ";
            }

            return result.Trim();
        }

        #endregion


        /// <summary>
        /// مثال لوکال فانکشن
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string MakePascal3(string sentence)
        {
            string LocalFunctionPascal(string word)
            {
                return word.Substring(0, 1).ToUpper() +
                       word.Substring(1).ToLower();
            }

            string[] words = sentence.Split(new char[] { ' ' });
            string newSentence = "";
            foreach (string word in words)
            {
                if (word.Length == 0)
                    continue;

                newSentence += $"{ LocalFunctionPascal(word)},";
            }

           

            return RemoveLastCharacter(newSentence);
        }


    }

}
