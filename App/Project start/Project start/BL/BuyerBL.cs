using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.BL
{
    internal class BuyerBL : UserBL
    {
        private string address;    //needed for delivery

        public BuyerBL(string address,string username, string password) : base(username, password, "Buyer")  //user = buyer
        {
            this.address = address;
            //other attributes are hanled by parent class-UserBL
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;

        }
            


    }
}
