using System;
using System.Collections.Generic;
using System.Text;

namespace TestAbpProject.AuthSignup
{
    public class AuthUserSignup
    {
        public string client_id;
        public string client_secret;
        public string connection;
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string name;
        public string email { get; set; }
        public string password { get; set; }
    }
}
