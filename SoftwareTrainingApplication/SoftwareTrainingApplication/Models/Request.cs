using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.Models
{
    internal class Request
    {
        public string id { get; set; }
        public string title { get; set; }
        public List<Chat> chats { get; set; }
    }
}
