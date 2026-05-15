using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal interface IUser    // interface used
    {
        string getUsername();
        string getPassword();
        string getPhoneNumber();
        string getRole();
    }
}
