using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class SellerBL : UserBL
    { 
        public SellerBL(string username, string password,string phoneNumber) : base (username,password, phoneNumber,"Seller")  //user = seller
        {  
            //attributes are hanled by parent class-UserBL
        }

    }
}
