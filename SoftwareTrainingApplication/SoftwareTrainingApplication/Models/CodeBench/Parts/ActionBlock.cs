using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.Models.CodeBench.Parts
{
    internal class ActionBlock : Block
    {
        public ActionBlock PreviousBlock;
        public ActionBlock NextBlock;
    }
}
