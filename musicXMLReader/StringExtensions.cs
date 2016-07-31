using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace musicXMLReader
{
    public static class StringExtensions
    {
        public static string StripLeadingWhitespace(this string s)
        {
            return Regex.Replace(s, @"[ \t]+\|", string.Empty);
        }
    }
}
