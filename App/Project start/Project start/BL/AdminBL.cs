using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class AdminBL : UserBL
    {
        public AdminBL(string username, string password,string phoneNumber) : base(username, password,phoneNumber, "Admin")  //user = seller
        {
            //attributes are hanled by parent class-UserBL
        }
    }
}
