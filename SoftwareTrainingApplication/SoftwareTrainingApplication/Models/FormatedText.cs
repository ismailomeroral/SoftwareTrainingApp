using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.Models
{
    internal class FormatedText
    {
        public string text;
        public List<(int Start, int Length, string process)> locations;
    }
}
