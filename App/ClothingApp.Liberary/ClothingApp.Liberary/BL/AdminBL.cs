using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{

    public class AdminBL : UserBL
    {
        public AdminBL(string username, string password, string phoneNumber) : base(username, password, phoneNumber, "Admin")  //user = Admin
        {
            //attributes are hanled by parent class-UserBL
        }
    }
}
