using System;
using System.Globalization;

namespace SadrTools.ExtensionMethods
{
    /// <summary>
    /// کلاس هایی که قرار است داخل آنها اکستنشن متد داشته باشیم بایداستاتیک باشند
    /// </summary>
    public static class DateExt
    {
        //Extension method must be defined in
        // a non-generic static class

        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جدا کننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate(this DateTime date, char separator = '/')
        {
            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(date);
            int month = pc.GetMonth(date);
            int day = pc.GetDayOfMonth(date);
            return $"{year}{separator}{month.ToString().PadLeft(2, '0')}{separator}{day.ToString().PadLeft(2, '0')}";
        }
   
    
    
    }
}
