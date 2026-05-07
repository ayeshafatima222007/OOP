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

        public BuyerBL(string address,string username, string password,string phoneNumber) : base(username, password,phoneNumber, "Buyer")  //user = buyer
        {
            setAddress(address);
            //other attributes are hanled by parent class-UserBL
        }

        public string getAddress()
        {
            return address;
        }

        public bool setAddress(string address)
        {
            if (address.Length == 0)
            {
                return false;
            }
            this.address = address;
            return true;
        }
            


    }
}
