using Project_start.BL; //BL class accessed from BL folder
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.DL
{
    internal class UserDL
    {
        public static List<UserBL> userList = new List<UserBL>();

        public static UserBL FindByUsername(string username)
        {
            foreach (UserBL user in userList)
            {
                if (user.getUsername() == username)
                {
                    return user;
                }
            }
            return null;
        }

        public static List<UserBL> FindByRole(string role)
        {
            List<UserBL> result = new List<UserBL>();        //goes for all type of users
            foreach (UserBL user in userList)
            {
                if (user.getRole() == role)
                {
                    result.Add(user);
                }
            }
            return result;
        }
        public static bool SignUp(UserBL user)
        {
            if (FindByUsername(user.getUsername()) != null)          // check if username already exists
            {
                return false;         //username is already exists
            }
            userList.Add(user);
            return true;           //signup done
        }

        public static UserBL FindUser(string username, string password)
        {
            foreach (UserBL user in userList)
            {
                if (user.getUsername() == username && user.getPassword() == password)
                {
                    return user;              //login done
                }
            }
            return null;           //invalid entry
        }
        public static void RemoveUser(string username)       //authority of admin to remove users
        {
            foreach (UserBL user in userList)
            {
                if (user.getUsername() == username)
                {
                    userList.Remove(user);
                    break;
                }
            }
        }


    }
}
