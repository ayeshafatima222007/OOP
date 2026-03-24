using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Departmental_Store
{
    internal class DepUser
    {
        public string Username;
        public string Password;
        public string Role;
        public static List<DepUser> UserList = new List<DepUser>();
        public DepUser(string Username, string Password, string Role)    //parameterized constructor
        {
            this.Username = Username;
            this.Password = Password;
            this.Role = Role;
             
        }

        public static void AddUserIntoList(DepUser user)
        {
            UserList.Add(user);
        }
        
        public static DepUser AvailableUser(DepUser user)
        {
            foreach (DepUser storedUser in UserList)
            {
                if (storedUser.Username == user.Username && storedUser.Password == user.Password)
                {
                    return storedUser;
                }
            }
            return null;
        }
    }
}
