using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAbpProject
{
    public class AwsCredential
    {
        public string AccessKey { get; set; }
        public string SecretAccess { get; set; }
        public string Profile { get; set; }
        public string Region { get; set; }
    }
}
