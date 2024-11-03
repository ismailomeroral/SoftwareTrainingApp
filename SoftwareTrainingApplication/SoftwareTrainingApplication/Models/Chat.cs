using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.Models
{
    internal class Chat
    {
        public string user { get; set; }
        public string message { get; set; }
        public Action<object, PropertyChangedEventArgs> PropertyChanged { get; internal set; }
    }
}
