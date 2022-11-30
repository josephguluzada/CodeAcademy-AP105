using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    internal static class StringExtension
    {
        public static string ToCapitalize(this string value) //yuSif -> Yusif
        {
            string newValue = char.ToUpper(value[0]) + value.Substring(1).ToLower();

            return newValue;
        }
    }
}
