using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{
    public interface IUser  //interface based
    {
        string getUsername();
        void setUsername(string username);

        string getPassword();
        void setPassword(string password);

        string getPhoneNumber();
        void setPhoneNumber(string phoneNumber);

        string getRole();
        void setRole(string role);
    }
}
