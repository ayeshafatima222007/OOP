using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp_SignIn_Role_Using_Class_and_limits
{
    internal class MUser
    {
        public string Username;
        public string Password;
        public string Role;
        public MUser(string username, string password, string role)   //parameterized constructor
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
