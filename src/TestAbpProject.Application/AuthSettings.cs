using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbpProject
{
    public class AuthSettings
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Connection { get; set; }
        public string Domain { get; set; }
        public string Audience { get; set; }
    }
}
