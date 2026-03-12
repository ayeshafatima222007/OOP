using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;      //used for sleep
using System.Threading.Tasks;

namespace signInSignUpRole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShopNameHeader();

            string choice;
            bool role = false;

            // array storing sign,signup material - moved outside loop so that data stay stored
            string[] user_S = new string[5];
            string[] pass_S = new string[5];
            string[] user_B = new string[5];
            string[] pass_B = new string[5];
            const int count = 5;

            LoadData(user_S, pass_S, count, "seller.txt");
            LoadData(user_B, pass_B, count, "buyer.txt");

            while (!role)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("             Select Your Role            ");
                Console.WriteLine("****************************************");
                Console.WriteLine("1.Seller");
                Console.WriteLine("2.Buyer");
                Console.WriteLine("3.Exit");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Enter your choice:  ");
                    choice=Console.ReadLine();
                    Console.WriteLine();

                    if (!validateChoice(choice, 3))
                    {
                        InvalidChoice();
                        continue;
                    }
                    break;
                }
                Console.Clear();

                if (choice == "1") ////   ------Entering into Seller Module--------
                {
                    string SellUser = "";
                    string SellPass = "";

                    bool SellerLoggedIn = false;

                    // conditions and calling funcations for sign in and login page
                    while (!SellerLoggedIn)
                    {
                        Console.Clear();
                        ShopNameHeader();

                        SellerModuleHeader();

                        while (true)
                        {
                            Console.Write("Enter your choice: ");
                            choice = Console.ReadLine();

                            if (!validateChoice(choice, 3))
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
                            SellerSignUpPage(user_S, pass_S, out SellUser,out SellPass, count);
                        }
                        else if (choice == "2")
                        {
                            SellerLoggedIn = SellerloginPage(user_S, pass_S, out SellUser,out SellPass, count);
                        }
                        else if (choice == "3")
                        {
                            exitprogramSeller(user_S, pass_S, count);
                            break;
                        }
                    }
                    if (SellerLoggedIn) // Only enter if logged in
                    {
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Because it's a Sign In and Sign Up page from both of the roles so you can only ");
                            Console.WriteLine("          see the functionalites if the user not performing them");

                            Console.WriteLine();


                            Console.WriteLine("Enter 6 to Exit from Seller Module");
                            SellerFunctionalities();

                            Console.WriteLine();
                            Console.Write("Enter your choice: ");
                            choice = Console.ReadLine();

                            if (!validateChoice(choice, 6))
                            {
                                InvalidChoice();
                                Thread.Sleep(1000);
                                continue;
                            }

                            if (choice == "6")
                            {
                                exitprogramSeller(user_S, pass_S, count);
                                break;
                            }
                        }
                    }
                }

                else if (choice == "2") //   ------Entering into Buyer Module--------
                {
                    string BuyUser = "";
                    string BuyPass = "";


                    bool BuyerLoggedIn = false;
                    // conditions and calling funcations for sign in and login page
                    while (!BuyerLoggedIn)
                    {
                        Console.Clear(); // Added clear screen for better UI
                        ShopNameHeader();

                        BuyerModuleHeader();

                        while (true)
                        {
                            Console.Write("Enter your choice:  ");
                            choice = Console.ReadLine();
                            Console.WriteLine();

                            if (!validateChoice(choice, 3))
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
                            BuyerSignUpPage(user_B, pass_B, out BuyUser, out BuyPass, count);
                        }
                        else if (choice == "2")
                        {
                            BuyerLoggedIn = BuyerloginPage(user_B, pass_B, out BuyUser,out BuyPass, count);
                        }
                        else if (choice == "3")
                        {
                            exitprogramBuyer(user_B, pass_B, count);
                            break;
                        }
                    }
                    if (BuyerLoggedIn) // Only enter if logged in
                    {
                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("Because it's a Sign In and Sign Up page from both of the roles so you can only ");
                            Console.WriteLine("          see the functionalites if the user not performing them");

                            Console.WriteLine();

                            BuyerFunctionalities();
                            Console.Write("Enter your choice:  ");
                            choice = Console.ReadLine();
                            Console.WriteLine();
                            if (!validateChoice(choice, 6))
                            {
                                InvalidChoice();
                                Thread.Sleep(1000);
                                continue;
                            }
                            if (choice == "4")
                            {
                                exitprogramSeller(user_B, pass_B, count);
                                break;
                            }
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("             Program is exiting...          *");
                    Console.WriteLine("       Press any key to close program       *");
                    Console.WriteLine("*********************************************");
                    Console.ReadKey(); // Wait for any key press
                
                }
            }
        }

        // ---------------------Validation Functions ------------------------------
        static bool validateChoice(string choice, int maxChoice)
        {
            if (choice.Length == 0)
            {
                return false;
            }

            // Check if choice contains only digits
            for (int i = 0; i < choice.Length; i++)
            {
                if (choice[i] < '0' || choice[i] > '9')
                {
                    return false;
                }
            }

            // Convert to integer and check range
            int choiceNum = int.Parse(choice);
            if (choiceNum < 1 || choiceNum > maxChoice)
            {
                return false;
            }

            return true;
        }

        static bool isValidName(string name)
        {
            if (name.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!((name[i] >= 'a' && name[i] <= 'z') ||
                      (name[i] >= 'A' && name[i] <= 'Z') ||
                      (name[i] == ' '))) // Allow spaces in names
                {
                    return false;
                }
            }
            return true;
        }

        static bool isValidPassword(string pass)
        {
            bool hasSpecial = false;
            bool number = false;
            bool hasUppar = false;
            bool hasLower = false;
            if (pass.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < pass.Length; i++)
            {
                if ((pass[i] >= '!' && pass[i] <= '/') || (pass[i] >= ':' && pass[i] <= '@'))
                {
                    hasSpecial = true;
                }
                else if (pass[i] >= '0' && pass[i] <= '9')
                {
                    number = true;
                }
                else if (pass[i] >= 'A' && pass[i] <= 'Z')
                {
                    hasUppar = true;
                }
                else if (pass[i] >= 'a' && pass[i] <= 'z')
                {
                    hasLower = true;
                }
            }
            return (hasSpecial && number && hasUppar && hasLower);
        }

        // Sign Up function as a seller
        static void SellerSignUpPage(string[] user_S, string[] pass_S,out string SellUser,out string SellPass, int count)
        {
            SignupHeader();
            while (true)
            {

                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("=> User name must contain only letters (spaces allowed");
                Console.Write("Enter username: "); // for sign up seller enter user name
                SellUser = Console.ReadLine();
                

                if (!isValidName(SellUser))
                {
                    Console.WriteLine("       Invalid Username !");
                    Console.WriteLine("Please enter the valid username.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("Password must contain: ");
                Console.WriteLine(" - At least one special character");
                Console.WriteLine(" - At least one number");
                Console.WriteLine(" - At least one capital letter");
                Console.WriteLine(" - At least one lowercase letter");
                Console.WriteLine();
                Console.Write("Enter password:  ");
                SellPass = Console.ReadLine();
                

                if (!isValidPassword(SellPass))
                {
                    Console.WriteLine();
                    Console.WriteLine("***            Invalid Password !       ***");
                    Console.WriteLine("***   Please enter the valid Password   ***");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < count; i++) // loop for passing the value of seller user name and password to its prespective arrays and not excedding the max number of seller as a user
            {
                if (user_S[i] == null )
                {
                    user_S[i] = SellUser;
                    pass_S[i] = SellPass;
                    Console.WriteLine();

                    SignUpSuccessful(); // design function
                    Thread.Sleep(1000);
                    return;
                }
            }
            SignUpUnsuccess(); // design function
        }

        // function for login as a seller
        static bool SellerloginPage(string[] user_S, string[] pass_S, out string SellUser,out string SellPass, int count)
        {
            LoginHeader(); // design function

            Console.WriteLine("[INSTRUCTION]");
            Console.WriteLine();
            Console.WriteLine("=> User name must contain only letters (spaces allowed");
            Console.Write("Enter username: "); // for sign up seller enter user name
            SellUser = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("[INSTRUCTION]");
            Console.WriteLine();
            Console.WriteLine("Password must contain: ");
            Console.WriteLine(" - At least one special character");
            Console.WriteLine(" - At least one number");
            Console.WriteLine(" - At least one capital letter");
            Console.WriteLine(" - At least one lowercase letter");
            Console.WriteLine();
            Console.Write("Enter password:  ");
            SellPass = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < count; i++) // loop for checking that the user entered password match with seller username and password
            {
                if (user_S[i] == SellUser && pass_S[i] == SellPass) // if user enterd username and password match with seller user name and password,then login successful
                {
                    LoginSuccessful();
                    return true;
                }
            }

            // if user enterd username and password doesn't match with seller user name and password,then login unsuccessful
            Console.WriteLine("*************************************"); // invalid login design
            Console.WriteLine("          Invalid login !!          *");
            Console.WriteLine("*************************************"); 
            Thread.Sleep(1000);

            return false;
        }

        // Sign Up function as a buyer
        static void BuyerSignUpPage(string[] user_B, string[] pass_B,out string BuyUser,out string BuyPass, int count)
        {
            SignupHeader();
            while (true)
            {
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("=> User name must contain only letters (spaces allowed");
                Console.Write("Enter username: "); // for sign up seller enter user name
                BuyUser = Console.ReadLine();
                Console.WriteLine();

                if (!isValidName(BuyUser))
                {
                    Console.WriteLine("       Invalid Username !");
                    Console.WriteLine("Please enter the valid username.");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("Password must contain: ");
                Console.WriteLine(" - At least one special character");
                Console.WriteLine(" - At least one number");
                Console.WriteLine(" - At least one capital letter");
                Console.WriteLine(" - At least one lowercase letter");
                Console.WriteLine();
                Console.Write("Enter password:  ");
                BuyPass = Console.ReadLine();
                Console.WriteLine();

                if (!isValidPassword(BuyPass))
                {
                    Console.WriteLine();
                    Console.WriteLine("***            Invalid Password !       ***");
                    Console.WriteLine("***   Please enter the valid Password   ***");
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < count; i++) // loop for passing the value of buyer user name and password to its prespective arrays and not excedding the max number of buyer as a user
            {
                if (user_B[i] == null)
                {
                    user_B[i] = BuyUser;
                    pass_B[i] = BuyPass;
                    Console.WriteLine();

                    SignUpSuccessful(); // design function
                    Thread.Sleep(1000);
                    return;
                }
            }
            SignUpUnsuccess(); // design function
        }

        // function for login as a buyer
        static bool BuyerloginPage(string[] user_B, string[] pass_B,out string BuyUser,out string BuyPass, int count)
        {
            LoginHeader(); // design function

            Console.WriteLine("[INSTRUCTION]");
            Console.WriteLine();
            Console.WriteLine("=> User name must contain only letters (spaces allowed");
            Console.Write("Enter username: "); // for sign up seller enter user name
            BuyUser = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("[INSTRUCTION]");
            Console.WriteLine();
            Console.WriteLine("Password must contain: ");
            Console.WriteLine(" - At least one special character");
            Console.WriteLine(" - At least one number");
            Console.WriteLine(" - At least one capital letter");
            Console.WriteLine(" - At least one lowercase letter");
            Console.WriteLine();
            Console.Write("Enter password:  ");
            BuyPass = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i < count; i++) // loop for checking that the user entered password match with buyer username and password
            {
                if (user_B[i] == BuyUser && pass_B[i] == BuyPass) // if user enterd username and password match with seller user name and password,then login successful
                {
                    LoginSuccessful(); // design function
                    return true;
                }
            }

            // if user enterd username and password doesn't match with seller user name and password,then login unsuccessful
            Console.WriteLine("*************************************"); // invalid login design
            Console.WriteLine("          Invalid login !!          *");
            Console.WriteLine("*************************************");
            Thread.Sleep(1000);

            return false;
        }

        //-----------------------File Handling-----------------------------------
        static void LoadData(string[] user, string[] pass, int count, string SellerBuyer) // function definition to load data by file handling as a txt file
        {
            string path = "C:\\C#\\SellerBuyer.txt";
            if (File.Exists(path))
            {
                StreamReader ReadingData = new StreamReader(path);
                string record;
                int i = 0;

                while((record = ReadingData.ReadLine())!=null && i<count)
                {
                    string[] temp = record.Split(' ');

                    if (temp.Length >= 2)
                    {
                        user[i] = temp[0];
                        pass[i] = temp[1];
                        i++;
                    }
                }
                ReadingData.Close();
            }

            else
            {
                Console.WriteLine("File not exists!! ");
            }
        }

        static void SaveData(string[] user, string[] pass, int count, string SellerBuyer) // function definition to save data by file handling
        {
            string path = "C:\\C#\\SellerBuyer.txt";
            StreamWriter WritingData = new StreamWriter(path,true);

            for (int i = 0; i < count; i++)
            {
                if (!string.IsNullOrEmpty(user[i]))
                {
                    WritingData.WriteLine(user[i] + " " + pass[i]);
                }
            }

            WritingData.Flush();    //it forces data which is to be written imediately 
            WritingData.Close();
        }

        static void exitprogramSeller(string[] user_S, string[] pass_S, int count) // exiting functionnof seller
        {
            SaveData(user_S, pass_S,count,"seller.txt");
            ExitModule();
        }

        static void exitprogramBuyer(string[] user_B, string[] pass_B, int count) // exiting function of buyer
        {
            SaveData(user_B, pass_B, count, "buyer.txt");
            ExitModule();
        }

        // ------------------------Header Functions --------------------------------
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
            Console.WriteLine("*     Invalid choice! Please enter 1, 2, or 3    *");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
        }

        static void SellerModuleHeader()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*                SELLER MODULE            *");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("* * * * * * * * * SUB MENU * * * * * * * * * ");
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Login In");
            Console.WriteLine("3.Exit");
        }

        static void BuyerModuleHeader() 
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("*                BUYER MODULE             *");
            Console.WriteLine("*******************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("* * * * * * * * * SUB MENU * * * * * * * * * ");
            Console.WriteLine("1.Sign Up");
            Console.WriteLine("2.Login In");
            Console.WriteLine("3.Exit");
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
            Console.WriteLine("1.View Product");
            Console.WriteLine("2.Search Product");
            Console.WriteLine("3.Buying product");
            Console.WriteLine("4. Exit");
        }

        static void SignupHeader()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("*                  Signing Up               *");
            Console.WriteLine("**************8******************************");
        }

        static void SignUpSuccessful()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("*             SignUp succussful !           *");
            Console.WriteLine("*********************************************");
            Thread.Sleep(1000);
        }

        static void SignUpUnsuccess()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("*             Sign Up unsucceful!           *");
            Console.WriteLine("*               Limit reached!              *");
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
            Console.WriteLine("*              Log In succussful !          *");
            Console.WriteLine("*********************************************");
            Thread.Sleep(1000);
        }

        static void ExitModule()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("*             Program is exiting...         *");
            Console.WriteLine("*       Press any key to close module       *");
            Console.WriteLine("*********************************************");

            Console.ReadKey();

        }
         
    }
}
