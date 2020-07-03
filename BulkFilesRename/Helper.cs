using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BulkFilesRename
{
    class Helper
    {
        public static string Template { get; set; }
        public static int StartingNumber { get; set; }
        public static IList<FileItem> FileItems { get; set; } = new List<FileItem>();
        public static string GetNewName(FileItem item)
        {
            var pattern = @"{(\d+)}";
            var match = Regex.Match(Template, pattern);
            if (match.Success)
            {
                var places = int.Parse(match.Groups[1].Value);
                return Regex.Replace(Template, pattern, GetNumber(FileItems.IndexOf(item), places));
            }
            return item.FileName;
        }

        private static string GetNumber(int index, int places)
        {
            int num = StartingNumber + index;
            string result = num.ToString();
            while (result.Length < places)
            {
                result = "0" + result;
            }
            return result;
        }
    }
}
