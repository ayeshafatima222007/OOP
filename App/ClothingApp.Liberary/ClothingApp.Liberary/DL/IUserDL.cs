using ClothingApp.Library.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.DL
{
    public interface IUserDL
    {
        bool SignUp(UserBL user);
        UserBL SignIn(string username, string password);
        UserBL FindByUsername(string username);
        List<UserBL> FindByRole(string role);
        bool RemoveUser(string username);
    }
}
