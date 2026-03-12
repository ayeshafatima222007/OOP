using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SignUp_SignIn_Role_Using_Class_and_limits
{

    namespace SignUp_SignIn_Role_Using_Class_and_limits
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                ShopNameHeader();

                string choice;

                List<MUser> users = new List<MUser>();
                LoadData(users);

                while (true)
                {
                    Console.WriteLine("             Select Your Role             ");
                    Console.WriteLine("1. Seller");
                    Console.WriteLine("2. Buyer");
                    Console.WriteLine("3. Exit");
                    Console.WriteLine();

                    Console.Write("Enter your choice: ");
                    choice = Console.ReadLine();

                    if (!ValidateChoice(choice, 3))
                    {
                        InvalidChoice();
                        continue;
                    }

                    Console.Clear();

                    if (choice == "1") // ------Entering into Seller Module--------
                    {
                        MUser loggedUser = null;

                        while (loggedUser == null)
                        {
                            Console.Clear();
                            ShopNameHeader();
                            SellerModuleHeader();

                            while (true)
                            {
                                Console.Write("Enter your choice: ");
                                choice = Console.ReadLine();

                                if (!ValidateChoice(choice, 3))
                                {
                                    InvalidChoice();
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    ShopNameHeader();
                                    SellerModuleHeader();
                                    continue;
                                }
                                break;
                            }

                            if (choice == "1")
                            {
                                SignUpPage(users, "Seller");
                            }
                            else if (choice == "2")
                            {
                                loggedUser = LoginPage(users, "Seller");
                            }
                            else if (choice == "3")
                            {
                                ExitProgram(users);
                                break;
                            }
                        }

                        if (loggedUser != null)
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Because it's a Sign In and Sign Up page from both of the roles so you can only");
                                Console.WriteLine("          see the functionalities if the user is not performing them");
                                Console.WriteLine();
                                Console.WriteLine("Enter 6 to Exit from Seller Module");
                                SellerFunctionalities();
                                Console.WriteLine();
                                Console.Write("Enter your choice: ");
                                choice = Console.ReadLine();

                                if (!ValidateChoice(choice, 6))
                                {
                                    InvalidChoice();
                                    Thread.Sleep(1000);
                                    continue;
                                }

                                if (choice == "6")
                                {
                                    ExitProgram(users);
                                    break;
                                }
                            }
                        }
                    }

                    else if (choice == "2") // ------Entering into Buyer Module--------
                    {
                        MUser loggedUser = null;

                        while (loggedUser == null)
                        {
                            Console.Clear();
                            ShopNameHeader();
                            BuyerModuleHeader();

                            while (true)
                            {
                                Console.Write("Enter your choice: ");
                                choice = Console.ReadLine();
                                Console.WriteLine();

                                if (!ValidateChoice(choice, 3))
                                {
                                    InvalidChoice();
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    BuyerModuleHeader();
                                    continue;
                                }
                                break;
                            }

                            if (choice == "1")
                            {
                                SignUpPage(users, "Buyer");
                            }
                            else if (choice == "2")
                            {
                                loggedUser = LoginPage(users, "Buyer");
                            }
                            else if (choice == "3")
                            {
                                ExitProgram(users);
                                break;
                            }
                        }

                        if (loggedUser != null)
                        {
                            while (true)
                            {
                                Console.Clear();
                                Console.WriteLine("Because it's a Sign In and Sign Up page from both of the roles so you can only");
                                Console.WriteLine("          see the functionalities if the user is not performing them");
                                Console.WriteLine();
                                BuyerFunctionalities();
                                Console.Write("Enter your choice: ");
                                choice = Console.ReadLine();
                                Console.WriteLine();

                                if (!ValidateChoice(choice, 4))
                                {
                                    InvalidChoice();
                                    Thread.Sleep(1000);
                                    continue;
                                }

                                if (choice == "4")
                                {
                                    ExitProgram(users);
                                    break;
                                }
                            }
                        }
                    }

                    else if (choice == "3")
                    {
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("*            Program is exiting...          *");
                        Console.WriteLine("*       Press any key to close program      *");
                        Console.WriteLine("*********************************************");
                        Console.ReadKey();
                        break;
                    }
                }
            }


            static bool ValidateChoice(string input, int max)
            {
                if (int.TryParse(input, out int val))
                    return val >= 1 && val <= max;
                return false;
            }

            static bool IsValidName(string name)
            {
                if (name.Length == 0) return false;

                for (int i = 0; i < name.Length; i++)
                {
                    if (!((name[i] >= 'a' && name[i] <= 'z') ||
                          (name[i] >= 'A' && name[i] <= 'Z') ||
                           name[i] == ' '))
                        return false;
                }
                return true;
            }

            static bool IsValidPassword(string pass)
            {
                if (pass.Length == 0) return false;

                bool hasSpecial = false, hasNumber = false, hasUpper = false, hasLower = false;

                for (int i = 0; i < pass.Length; i++)
                {
                    if ((pass[i] >= '!' && pass[i] <= '/') || (pass[i] >= ':' && pass[i] <= '@'))
                        hasSpecial = true;
                    else if (pass[i] >= '0' && pass[i] <= '9')
                        hasNumber = true;
                    else if (pass[i] >= 'A' && pass[i] <= 'Z')
                        hasUpper = true;
                    else if (pass[i] >= 'a' && pass[i] <= 'z')
                        hasLower = true;
                }
                return hasSpecial && hasNumber && hasUpper && hasLower;
            }


            static void SignUpPage(List<MUser> users, string role)
            {
                SignupHeader();
                string username;
                while (true)
                {
                    Console.WriteLine("[INSTRUCTION]");
                    Console.WriteLine("=> Username must contain only letters (spaces allowed)");
                    Console.Write("Enter username: ");
                    username = Console.ReadLine();

                    if (!IsValidName(username))
                    {
                        Console.WriteLine("       Invalid Username!");
                        Console.WriteLine("Please enter a valid username.");
                        Console.WriteLine();
                    }
                    else break;
                }

                string password;
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("[INSTRUCTION]");
                    Console.WriteLine("Password must contain:");
                    Console.WriteLine(" - At least one special character");
                    Console.WriteLine(" - At least one number");
                    Console.WriteLine(" - At least one capital letter");
                    Console.WriteLine(" - At least one lowercase letter");
                    Console.WriteLine();
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();

                    if (!IsValidPassword(password))
                    {
                        Console.WriteLine();
                        Console.WriteLine("***            Invalid Password!        ***");
                        Console.WriteLine("***   Please enter a valid password.    ***");
                    }
                    else break;
                }

                users.Add(new MUser(username, password, role));
                Console.WriteLine();
                SignUpSuccessful();
                Thread.Sleep(1000);
            }


            static MUser LoginPage(List<MUser> users, string role)
            {
                LoginHeader();

                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine("=> Username must contain only letters (spaces allowed)");
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                Console.WriteLine();

                foreach (MUser u in users)
                {
                    if (u.Role == role && u.Username == username && u.Password == password)
                    {
                        LoginSuccessful();
                        return u;
                    }
                }

                Console.WriteLine("*************************************");
                Console.WriteLine("*          Invalid login !!         *");
                Console.WriteLine("*************************************");
                Thread.Sleep(1000);
                return null;
            }

            static void LoadData(List<MUser> users)
            {
                string path = "users.txt";

                if (!File.Exists(path)) return;

                StreamReader reader = new StreamReader(path);
                string record;

                while ((record = reader.ReadLine()) != null)
                {
                    string[] parts = record.Split(' ');
                    if (parts.Length >= 3)
                    {
                        users.Add(new MUser(parts[0], parts[1], parts[2]));
                    }
                }
                reader.Close();
            }

            static void SaveData(List<MUser> users)
            {
                string path = "users.txt";
                StreamWriter writer = new StreamWriter(path, false);

                foreach (MUser u in users)
                {
                    writer.WriteLine(u.Username + " " + u.Password + " " + u.Role);
                }

                writer.Flush();
                writer.Close();
            }

            static void ExitProgram(List<MUser> users)
            {
                SaveData(users);
                Console.WriteLine("*********************************************");
                Console.WriteLine("*           Module is exiting...            *");
                Console.WriteLine("*       Press any key to close module       *");
                Console.WriteLine("*********************************************");
                Console.ReadKey();
            }


            static void ShopNameHeader()
            {
                Thread.Sleep(50);
                Console.WriteLine("           ____      __     __            _____ _    _  ____  _____  \r");
                Thread.Sleep(50);
                Console.WriteLine("     /\\   |  _ \\   /\\\\ \\   / //\\         / ____| |  | |/ __ \\|  __ \\ ");
                Thread.Sleep(50);
                Console.WriteLine("    /  \\  | |_) | /  \\\\ \\_/ //  \\       | (___ | |__| | |  | | |__) |");
                Thread.Sleep(50);
                Console.WriteLine("   / /\\ \\ |  _ < / /\\ \\\\   // /\\ \\       \\___ \\|  __  | |  | |  ___/ ");
                Thread.Sleep(50);
                Console.WriteLine("  / ____ \\| |_) / ____ \\| |/ ____ \\      ____) | |  | | |__| | |     ");
                Thread.Sleep(50);
                Console.WriteLine(" /_/    \\_\\____/_/    \\_\\_/_/    \\_\\    |_____/|_|  |_|\\____/|_|     ");
            }

            static void InvalidChoice()
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine("*    Invalid choice! Please enter a valid option  *");
                Console.WriteLine("**************************************************");
                Console.WriteLine();
            }

            static void SellerModuleHeader()
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*              SELLER MODULE              *");
                Console.WriteLine("*******************************************");
                Console.WriteLine();
                Console.WriteLine("* * * * * * * * * SUB MENU * * * * * * * * *");
                Console.WriteLine("1. Sign Up");
                Console.WriteLine("2. Log In");
                Console.WriteLine("3. Exit");
            }

            static void BuyerModuleHeader()
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("*               BUYER MODULE              *");
                Console.WriteLine("*******************************************");
                Console.WriteLine();
                Console.WriteLine("* * * * * * * * * SUB MENU * * * * * * * * *");
                Console.WriteLine("1. Sign Up");
                Console.WriteLine("2. Log In");
                Console.WriteLine("3. Exit");
            }

            static void SellerFunctionalities()
            {
                Console.WriteLine("* * * * * * * * MAIN MENU AS SELLER * * * * * * * *");
                Console.WriteLine();
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Product");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Exit");
            }

            static void BuyerFunctionalities()
            {
                Console.WriteLine("* * * * * * * * MAIN MENU AS BUYER * * * * * * * *");
                Console.WriteLine();
                Console.WriteLine("1. View Product");
                Console.WriteLine("2. Search Product");
                Console.WriteLine("3. Buy Product");
                Console.WriteLine("4. Exit");
            }

            static void SignupHeader()
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("*                 Signing Up                *");
                Console.WriteLine("*********************************************");
            }

            static void SignUpSuccessful()
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("*           Sign Up Successful!             *");
                Console.WriteLine("*********************************************");
                Thread.Sleep(1000);
            }

            static void SignUpUnsuccess()
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("*           Sign Up Unsuccessful!           *");
                Console.WriteLine("*              Limit Reached!               *");
                Console.WriteLine("*********************************************");
                Thread.Sleep(1000);
            }

            static void LoginHeader()
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("*                 Logging In                *");
                Console.WriteLine("*********************************************");
            }

            static void LoginSuccessful()
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("*            Log In Successful!             *");
                Console.WriteLine("*********************************************");
                Thread.Sleep(1000);
            }
        }
    }
}