using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadrTools.ExtensionMethods
{
    public static class StringExt
    {
        internal static string MakeItPascal(this string word)
        {
            return word.Substring(0, 1).ToUpper() +
                   word.Substring(1).ToLower();
        }

        public static string RemoveLastCharacter(this string str)
        {
            return str.Substring(0, str.Length - 1);
        }

        public static string MakePascal(this string sentence)
        {
            //string[] words = sentence.Split(new char[] { ' ' });
           
              string[] words = sentence.Split(' ');


            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == 0)
                    continue;

                words[i] = words[i].MakeItPascal();
            }

            return words.GetString();

        }

        public static int ToInt32(this string str)
        {
            // Error Handling
            return Convert.ToInt32(str);
        }
    }
}
