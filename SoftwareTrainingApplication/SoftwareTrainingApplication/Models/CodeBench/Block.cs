using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.Models.CodeBench
{
    internal class Block
    {
        public string name;
        public string info;
        public (int X, int Y) Location;
        public (int Width, int Height) Size;
        public Color Color;
    }
}
