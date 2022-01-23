using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadrTools.Utility
{
    public static class Utility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="miliSecond"></param>
        public static void Sleep(int miliSecond = 20)
        {
            System.Threading.Thread.Sleep(miliSecond);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumber()
        {
            Sleep();
            return new Random().Next();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomNumber(int max)
        {
            Sleep();
            return new Random().Next(max+1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int GetRandomNumber(int min ,int max)
        {
            Sleep();
            return new Random().Next(min , max+1);
        }

    }
}
