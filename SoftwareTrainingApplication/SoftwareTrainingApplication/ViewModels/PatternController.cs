using SoftwareTrainingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class PatternController
    {
        public static Match LearnPattern(string _input, string _pattern)
        {
          return  Regex.Match(_input, _pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }
        public static MatchCollection LearnPatterns(string _input, string _pattern)
        {
          return  Regex.Matches(_input, _pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }
        public static string ReplacePattern(string _input, string _pattern, string _replacement)
        {
           return Regex.Replace(_input, _pattern, _replacement, RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }
    }
}
