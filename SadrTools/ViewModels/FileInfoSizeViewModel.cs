using System;

namespace SadrTools.ViewModels
{
    /// <summary>
    /// این اولین کلاس غیر استاتیک ما میباشد
    /// این کلاس فقط جهت نمایش اطلاعات خروجی متد مورد نظر تعریف شده است
    /// </summary>
    public class FileInfoSizeViewModel
    {

        //Anonymous Type VS ViewModel
        // سریع و راحت
        // کد نویسی کمتری داره
        //----------------
        // اسم و رسم نداره
        // کامنت ایکس ام ال نمیتواند داشته باشد
        // فقط همونجایی که تعریف شده قابل استفاده است
        // نمیتواند به عنوان ورودی یا خروجی متد قرار بگیرد
        // دسترسی به آیتم های آن در همه جا ممکن نیست




        /// <summary>
        /// نام فایل
        /// </summary>
        public string TheFileName    {get;set;}
       public long TheSizeInByte  {get;set;}
       public long TheSizeInKB    {get;set;}
       public ulong TheSizeInMB    {get;set;}
       public ulong TheSizeInGB    {get;set;}
    }
}
