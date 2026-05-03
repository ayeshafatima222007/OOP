using Project_start.BL; //****
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

        public static void AddUser(UserBL user)
        {
            userList.Add(user);
        }

        public static UserBL FindUser(string username,string password)
        {
            foreach (UserBL user in userList)
            {
                if (user.getUsername() == username && user.getPassword() == password)
                {
                    return user;     //found
                }
            }
            return null;      //not found
        }

    }
}
