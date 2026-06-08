using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.BL
{
    public abstract class UserBL : IUser
    {
        protected string username;
        protected string password;
        protected string role;
        protected string phoneNumber;

        public UserBL(string username, string password, string phoneNumber, string role)
        {
            this.username = username;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.role = role;
        }

        public string getUsername()
        {
            return username;
        }

        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string getRole()
        {
            return role;
        }

        public void setRole(string role)
        {
            this.role = role;
        }
    }
}
