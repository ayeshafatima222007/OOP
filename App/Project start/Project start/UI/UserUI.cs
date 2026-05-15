using Project_start.BL;
using Project_start.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_start.UI
{
    internal class UserUI
    {
        public static void SignUp()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string phone = Console.ReadLine();

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            BuyerBL buyer = new BuyerBL(address, username, password, phone);

            bool success = UserDL.SignUp(buyer);

            if (success)
            {
                Console.WriteLine("Sign up successful!");
            }
            else
            {
                Console.WriteLine("Username already exists or invalid input!");
            }
        }

        public static void Login()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            UserBL user = UserDL.FindUser(username, password);

            if (user == null)
            {
                Console.WriteLine("Invalid username or password!");
                return;
            }

            Console.WriteLine($"Login successful! Welcome {user.getUsername()}");
        }

        public static void RemoveUser()
        {
            Console.Write("Enter username to remove: ");
            string username = Console.ReadLine();

            UserBL user = UserDL.FindByUsername(username);
            if (user == null)
            {
                Console.WriteLine("User not found!");
                return;
            }
            UserDL.RemoveUser(username);
            Console.WriteLine("User removed successfully!");
        }

        public static void ViewAllUsers()
        {
            var users = UserDL.userList;
            if (users.Count == 0)
            {
                Console.WriteLine("No users found!");
                return;
            }
            foreach (UserBL u in users)
            {
                Console.WriteLine($"Username: {u.getUsername()}  | Role:  {u.getRole()}  | Phone: {u.getPhoneNumber()}");
            }
        }

    }
}
