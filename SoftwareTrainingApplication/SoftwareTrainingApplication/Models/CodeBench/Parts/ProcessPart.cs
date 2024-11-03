using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.Models.CodeBench.Parts
{
    internal class ProcessPart : Block
    {
        public dynamic value { get; private set; }
        public ProcessPart insidePart;
        public void ValueSet(string value)
        {
        }
    }
}
