using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_start.BL
{
    internal abstract class UserBL : IUser            //Abstract class
    {
        protected string username;
        protected string password;
        protected string role;
        protected string phoneNumber;


        public UserBL(string username, string password, string phoneNumber,string role)
        {
            setUsername(username);
            setPassword(password);
            setPhoneNumber(phoneNumber);
            this.role = role;
        }

        public string getUsername()
        { 
            return username; 
        }

        public bool setUsername(string username)
        {
            if (username.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < username.Length; i++)
            {
                if (!((username[i] >= 'a' && username[i] <= 'z') ||
                      (username[i] >= 'A' && username[i] <= 'Z') ||
                      (username[i] == ' '))) // Allow spaces in names
                {
                    return false;
                }
            }
            this.username = username;
            return true;
        }
         
        public string getPassword() 
        {
            return password; 
        }

        public bool setPassword(string password)
        {
            bool hasSpecial = false;
            bool number = false;
            bool hasUppar = false;
            bool hasLower = false;
            if (password.Length == 0)
            {
                return false;
            }

            if (password.Length < 5 || password.Length > 8)        //must be between 5-8 characters
            {
                return false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= '!' && password[i] <= '/') || (password[i] >= ':' && password[i] <= '@'))     //has special character
                {
                    hasSpecial = true;
                }
                else if (password[i] >= '0' && password[i] <= '9')    //has a number
                {
                    number = true;
                }
                else if (password[i] >= 'A' && password[i] <= 'Z')    //has a capital letter
                {
                    hasUppar = true;
                }
                else if (password[i] >= 'a' && password[i] <= 'z')       //has small letter
                {
                    hasLower = true;
                }
            }
            if (hasSpecial && number && hasUppar && hasLower)  
            {
                this.password = password;
                return true; 
            }
            return false;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public bool setPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {
                return false;
            }

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (phoneNumber[i] < '0' || phoneNumber[i] > '9')
                {
                    return false;
                }
            }

            this.phoneNumber = phoneNumber;
            return true;
        }
        public string getRole() 
        {
            return role;
        }

        public void setRole(string role)
        {
            this.role=role;
        }
    }
}
