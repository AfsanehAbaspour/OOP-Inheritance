using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using SadrTools.ViewModels;

namespace SadrTools.ExtensionMethods
{
    public static class IOExt
    {
       
 
        public static IEnumerable GetInformationList(this IEnumerable<FileInfo> files , bool isAscending = true)
        {
            var result = from f in files
                         select new
                         {
                             TheFileName = f.Name,
                             TheSizeInByte = f.Length,
                             TheSizeInKB = (f.Length / 1024),
                             TheSizeInMB = (f.Length / Math.Pow(1024,2)),
                             TheSizeInGB = f.Length / (Math.Pow(1024,3)),
                         };

            result = isAscending ?
                     result.OrderBy(x => x.TheSizeInByte) :
                     result.OrderByDescending(x => x.TheSizeInByte);

            return result.ToList(); 

        }


        public static string GetInformationStr(this IEnumerable<FileInfo> files, bool isAscending = true)
        {
            var result = from f in files
                         select new
                         {
                             
                             TheFileName = f.Name,
                             TheSizeInByte = f.Length,
                             TheSizeInKB = (f.Length / 1024),
                             TheSizeInMB = (f.Length / Math.Pow(1024, 2)),
                             TheSizeInGB = f.Length / (Math.Pow(1024, 3)),
                         };

            result = isAscending ?
                     result.OrderBy(x => x.TheSizeInByte) :
                     result.OrderByDescending(x => x.TheSizeInByte);


            var str = "";
            foreach (var item in result)
            {
                str += item.TheFileName + " " + item.TheSizeInKB + "\n";
            }

            return str;



        }


        public static List<FileInfoSizeViewModel> GetInformationViewModel(this IEnumerable<FileInfo> files, bool isAscending = true)
        {
            var result = from f in files
                         select new FileInfoSizeViewModel
                         {
                             TheFileName = f.Name,
                             TheSizeInByte = f.Length,
                             TheSizeInKB = (f.Length / 1024),
                             TheSizeInMB = Convert.ToUInt64(f.Length / Math.Pow(1024, 2)),
                             TheSizeInGB = Convert.ToUInt64(f.Length / (Math.Pow(1024, 3))),
                         };

            result = isAscending ?
                     result.OrderBy(x => x.TheSizeInByte) :
                     result.OrderByDescending(x => x.TheSizeInByte);

            return result.ToList();

        }


    }
}
