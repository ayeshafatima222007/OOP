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
        const int MAX_PROD = 50;
        static void Main(string[] args)
        {


            ShopNameHeader();

            string choice;
            bool role = false;

            // array storing sign,signup material - moved refside loop so that data stay stored
            string[] user_S = new string[5];
            string[] pass_S = new string[5];
            string[] user_B = new string[5];
            string[] pass_B = new string[5];
            const int count = 5;


            // arrays storing product data
            string[] prodID = new string[MAX_PROD];
            string[] prodName = new string[MAX_PROD];
            string[] prodPrice = new string[MAX_PROD];
            string[] prodClr = new string[MAX_PROD];
            string[] prodsize = new string[MAX_PROD];
            string[] prodSeller = new string[MAX_PROD];
            int[] prodQty = new int[MAX_PROD];
            int prodCount = 0; // tracks how many datas are added

            LoadData(user_S, pass_S, count, "seller.txt");
            LoadData(user_B, pass_B, count, "buyer.txt");

            while (!role)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("             Select Your Role              ");
                Console.WriteLine("*******************************************");
                Console.WriteLine("1.Seller");
                Console.WriteLine("2.Buyer");
                Console.WriteLine("3.Exit");
                Console.WriteLine();

                while (true)
                {
                    Console.Write("Enter your choice:  ");
                    choice = Console.ReadLine();
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
                            SellerSignUpPage(user_S, pass_S, ref SellUser, ref SellPass, count);
                        }
                        else if (choice == "2")
                        {
                            SellerLoggedIn = SellerloginPage(user_S, pass_S, ref SellUser, ref SellPass, count);
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

                            SellerFunctionalities();

                            while (true)
                            {
                                Console.Write("Enter your choice: ");
                                choice = Console.ReadLine();
                                Console.WriteLine();

                                if (!validateChoice(choice, 6))
                                {
                                    InvalidChoice();
                                    Thread.Sleep(1000);
                                    Console.Clear();

                                    ShopNameHeader();

                                    SellerFunctionalities();
                                    continue;
                                }
                                break;
                            }
                            if (choice == "1")
                            {
                                addProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, SellUser);
                            }
                            else if (choice == "2")
                            {
                                viewProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, SellUser);
                            }
                            else if (choice == "3")
                            {
                                updateProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, SellUser);
                            }
                            else if (choice == "4")
                            {
                                deleteProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, SellUser);
                            }
                            else if (choice == "5")
                            {
                                searchProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, SellUser);
                            }
                            else if (choice == "6")
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
                            BuyerSignUpPage(user_B, pass_B, ref BuyUser, ref BuyPass, count);
                        }
                        else if (choice == "2")
                        {
                            BuyerLoggedIn = BuyerloginPage(user_B, pass_B, ref BuyUser, ref BuyPass, count);
                        }
                        else if (choice == "3")
                        {
                            exitprogramBuyer(user_B, pass_B, count);
                            break;
                        }
                    }

                    // conditions and function calling for main menu of buyer
                    if (BuyerLoggedIn)       // Only enter if logged in
                    {
                        while (true)
                        {
                            Console.Clear();

                            BuyerFunctionalities();
                            while (true)
                            {
                                Console.Write("Enter your choice:  ");
                                choice = Console.ReadLine();
                                Console.WriteLine();
                                if (!validateChoice(choice, 6))
                                {
                                    InvalidChoice();
                                    Thread.Sleep(1000);

                                    Console.Clear();
                                    BuyerFunctionalities();
                                    continue;
                                }
                                break;
                            }

                            if (choice == "1")
                            {
                                viewProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, "BUYER");
                            }
                            else if (choice == "2")
                            {
                                searchProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount, "BUYER");
                            }
                            else if (choice == "3")
                            {
                                buyingProduct(prodID, prodName, prodsize, prodClr, prodPrice, prodQty, prodSeller, ref prodCount);

                            }
                            else if (choice == "4")
                            {
                                exitprogramBuyer(user_B, pass_B, count);
                                break; // Added break to exit the loop
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

                    role = true;
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

        // validation check function of unique id of product
        static bool validateUniqueID(string[] prodID, string UniqID, int count)
        {
            if (UniqID.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < count; i++)
            {
                if (prodID[i] == UniqID)
                {
                    return false;
                }
            }
            return true;
        }

        static bool validateIntPrice(string a) // validation function for changing the price if the seller enter price rather than in any other datatype
        {
            if (a.Length == 0) // if string length is 0 so no product is there
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++) // loop for checking the input is in int or string
            {

                if (a[i] < '0' || a[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        // function for validation of size of the product
        static bool validateProductSize(string size)
        {
            if (size.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < size.Length; i++)
            {
                if (!((size[i] == 'S' || size[i] == 's') || (size[i] == 'M' || size[i] == 'm') || (size[i] == 'L' || size[i] == 'l')))
                {
                    return false;
                }
            }
            return true;
        }

        // function for returning to main menu for seller
        static void returnmenu()
        {
            string temp;
            Console.WriteLine("--------------------------------------");
            while (true)
            {
                Console.Write("Enter any number to return to main menu: ");
                temp = Console.ReadLine();
                if (!validateIntPrice(temp)) // calling validation function of price to use it for number entring
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! Please enter numbers only.");
                    Console.WriteLine();
                    continue;
                }
                break;
            }
            Console.WriteLine("------------------------------------");
            Console.Clear();
        }


        // Sign Up function as a seller
        static void SellerSignUpPage(string[] user_S, string[] pass_S, ref string SellUser, ref string SellPass, int count)
        {
            SignupHeader();
            while (true)
            {

                Console.WriteLine("-[INSTRUCTION]-");
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
                if (user_S[i] == null)
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
        static bool SellerloginPage(string[] user_S, string[] pass_S, ref string SellUser, ref string SellPass, int count)
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
        static void BuyerSignUpPage(string[] user_B, string[] pass_B, ref string BuyUser, ref string BuyPass, int count)
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
        static bool BuyerloginPage(string[] user_B, string[] pass_B, ref string BuyUser, ref string BuyPass, int count)
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

        // add product function for seller
        static void addProduct(string[] prodID, string[] prodName, string[] prodsize, string[] prodClr, string[] prodPrice, int[] prodQty, string[] prodSeller, ref int prodCount, string currentSeller)
        {
            string tempPrice, tempId, tempColor, tempName, tempSize; // defining datatype to enter data
            int tempQty;

            if (prodCount >= MAX_PROD) // if limit of the of the max product reached than no product is further added
            {
                Console.WriteLine("***   Cannot add more Product.Storage full !!   ***");

            }

            // take product data from seller
            while (true)
            {
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("The product ID must be unique.");
                Console.WriteLine();
                Console.Write("Enter product ID: "); // taking input ID from seller to add product
                tempId = Console.ReadLine();

                if (!validateUniqueID(prodID, tempId, prodCount))
                {
                    Console.WriteLine("***   Invalid ID! ID must be unique.   ***");
                    continue;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Enter Product name:  "); // taking input name for adding product
            tempName = Console.ReadLine();

            while (true) // checking the validity for the price to be in int
            {
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("Enter in integers");
                Console.Write("Enter product price: ");
                tempPrice = Console.ReadLine();

                if (!validateIntPrice(tempPrice)) // validation not true means the seller enter the price in datatype other than int
                {
                    Console.WriteLine("***  Invalid price! Please enter a valid integer.   ***");
                    continue;
                }
                else // otherwise if the user enterd price in correct datatype(int)
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("=> color must not contain any number and space.");
                Console.Write("Enter the color of Product: "); // taking input colour for adding product
                tempColor = Console.ReadLine();
                if (!isValidName(tempColor))
                {
                    Console.WriteLine("***   Invalid color ! Please enter a valid color.   ***");
                    continue;
                }
                else // otherwise if the user enterd price in correct datatype(int)
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Enter the size of product  (S,M,L or s,m,l): ");
                tempSize = Console.ReadLine();
                if (!validateProductSize(tempSize))
                {
                    Console.WriteLine();
                    Console.Write("***          Invalid Size !       ***");
                    Console.Write("***   Please enter a valid size.  ***");
                    Console.WriteLine();
                    continue;
                }
                else // otherwise if the user enterd price in correct datatype(int)
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("[INSTRUCTION]");
                Console.WriteLine();
                Console.WriteLine("=> Must be a valid number");
                Console.WriteLine();
                Console.Write("Enter product quantity: ");

                if (!int.TryParse(Console.ReadLine(), out tempQty))
                {
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine("***   Invalid input! Please enter a valid integer.   ***");
                    Console.WriteLine();
                    continue;
                }
                if (tempQty < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("***       Invalid quantity!   *** ");
                    Console.WriteLine("***   Please enter a positive number.   ***");
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    break;
                }
            }

            prodID[prodCount] = tempId; // storing the values in array
            prodName[prodCount] = tempName;
            prodsize[prodCount] = tempSize;
            prodClr[prodCount] = tempColor;
            prodPrice[prodCount] = tempPrice;
            prodQty[prodCount] = tempQty;
            prodSeller[prodCount] = currentSeller;

            prodCount++;

            Console.WriteLine("***************************************"); // product adding design
            Console.WriteLine("*     Product added successfully       *");
            Console.WriteLine("****************************************");
            Console.WriteLine();


            returnmenu();
        }

        // function to view all Products for seller
        static void viewProduct(string[] prodID, string[] prodName, string[] prodsize, string[] prodClr, string[] prodPrice, int[] prodQty, string[] prodSeller, ref int prodCount, string viewer)
        {
            if (prodCount == 0) // if product count is zero so no product is added
            {
                Console.WriteLine();
                Console.WriteLine("*****  No Products added!  *****");
                return;
            }

            Console.WriteLine("**********************************");
            Console.WriteLine("*--------  PRODUCT LIST  --------*");
            Console.WriteLine("**********************************");
            Console.WriteLine();

            // Count visible products
            int visibleCount = 0;
            for (int i = 0; i < prodCount; i++)
            {
                if (viewer == "BUYER" || prodSeller[i] == viewer)
                {
                    visibleCount++;
                }
            }

            Console.WriteLine("\t\tTotal Product: " + visibleCount + "\n"); // showing total number of products added by seller

            // using setw() to define the headers with fixed width,so make the table allign
            Console.WriteLine("==============================================================================");
            Console.WriteLine($"{"ID",-10}" + $"{"Name",-18}" + $"{"Price",-12}" + $"{"Colour",-14}" + $"{"Size",-10}" + $"{"Quantity",-10}");
            Console.WriteLine("==============================================================================");

            for (int i = 0; i < prodCount; i++) // loop for showing total number of products added by seller onr by one
            {
                if (viewer == "BUYER" || prodSeller[i] == viewer)
                {
                    Console.WriteLine($"{prodID[i],-10}" + $"{prodName[i],-18}" + $"{prodPrice[i],-12}" + $"{prodClr[i],-14}" + $"{prodsize[i],-10}" + $"{prodQty[i],-10}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("==============================================================================");

            returnmenu();
        }

        // function to update product data   (only for seller)
        static void updateProduct(string[] prodID, string[] prodName, string[] prodsize, string[] prodClr, string[] prodPrice, int[] prodQty, string[] prodSeller, ref int prodCount, string currentSeller)
        {
            string tempName, tempColor, tempSize, tempPrice;
            int tempQty;
            if (prodCount == 0)
            {
                Console.WriteLine("No product to update!");

            }
            string id;
            Console.Write("Enter Product ID to update: ");
            id = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < prodCount; i++) // to search product by ID
            {
                if (prodID[i] == id && prodSeller[i] == currentSeller)
                {
                    found = true;
                    Console.WriteLine("*----------Product found----------*");
                    Console.WriteLine($"Current name: {prodName[i]}");
                    Console.WriteLine($"Current price: {prodPrice[i]}");
                    Console.WriteLine($"Current colour: {prodClr[i]}");
                    Console.WriteLine($"Current size: {prodsize[i]}");
                    Console.WriteLine($"Current Quantity: {prodQty[i]}");

                    while (true)
                    {
                        // updating data
                        Console.Write("Enter new name: ");
                        tempName = Console.ReadLine();
                        if (!isValidName(tempName))
                        {
                            Console.WriteLine("***          Invalid Username !   ***");
                            Console.WriteLine("***   Please enter the valid username.   ***");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.Write("Enter new price: ");
                        tempPrice = Console.ReadLine();
                        if (!validateIntPrice(tempPrice)) // validation not true means the seller enter the price in datatype other than int
                        {
                            Console.WriteLine("***   Invalid price! Please enter a valid integer.  ***");
                            continue;
                        }
                        else // otherwise if the user enterd price in correct datatype(int)
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.Write("Enter new colour: ");
                        tempColor = Console.ReadLine();
                        if (!isValidName(tempColor))
                        {
                            Console.WriteLine("***   Please enter the valid color name. ***");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.Write("Enter new size (S,M,L OR s,m,l) : ");
                        tempSize = Console.ReadLine();
                        if (!validateProductSize(tempSize))
                        {
                            Console.WriteLine("***   Please enter the correct size!   ***");
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Enter product quantity: ");


                        if (!int.TryParse(Console.ReadLine(), out tempQty))
                        {
                            Console.Clear();

                            Console.WriteLine();
                            Console.WriteLine("***    Invalid input! Please enter a valid integer.     ***");
                            Console.WriteLine();
                            continue;
                        }
                        if (tempQty < 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("***        Invalid quantity!     *** ");
                            Console.WriteLine("***    Please enter a positive number.     ***");
                            Console.WriteLine();
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    prodName[i] = tempName;
                    prodClr[i] = tempColor;
                    prodPrice[i] = tempPrice;
                    prodsize[i] = tempSize;
                    prodQty[i] = tempQty;

                    Console.WriteLine();
                    Console.WriteLine("  ******    [Product updated successfully]    ***");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine();
                Console.WriteLine("   ***   No product ID is found!   ***");
            }
            returnmenu();
        }

        // function to delete product data using their ID
        static void deleteProduct(string[] prodID, string[] prodName, string[] prodsize, string[] prodClr, string[] prodPrice, int[] prodQty, string[] prodSeller, ref int prodCount, string currentSeller)
        {
            if (prodCount == 0)
            {
                Console.WriteLine("***   No product to delete!   ***");
                return;
            }

            string id;
            Console.Write("\t\tEnter Product's ID to delete: ");
            id = Console.ReadLine();

            bool found = false;

            // to search product by ID
            for (int i = 0; i < prodCount; i++)
            {
                if (prodID[i] == id && prodSeller[i] == currentSeller)
                {
                    found = true;

                    for (int j = i; j < prodCount - 1; j++)
                    {
                        prodID[j] = prodID[j + 1];
                        prodName[j] = prodName[j + 1];
                        prodPrice[j] = prodPrice[j + 1];
                        prodClr[j] = prodClr[j + 1];
                        prodsize[j] = prodsize[j + 1];
                        prodQty[j] = prodQty[j + 1];
                        prodSeller[j] = prodSeller[j + 1];
                    }

                    prodCount--;

                    Console.WriteLine();
                    Console.WriteLine("***   [ Product deleted successfully! ]   ***");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("***   Product not found.   ***");
            }

            returnmenu();
        }

        // function to search any product by using their ID
        static void searchProduct(string[] prodID, string[] prodName, string[] prodsize, string[] prodClr, string[] prodPrice, int[] prodQty, string[] prodSeller, ref int prodCount, string viewer)
        {
            if (prodCount == 0)
            {
                Console.WriteLine("\t\t***   No product to search!   ***");

            }

            bool found = false;
            string id;
            Console.Write("Enter product ID to search: ");
            id = Console.ReadLine();

            for (int i = 0; i < prodCount; i++)
            {
                if (prodID[i] == id && (viewer == "BUYER" || prodSeller[i] == viewer))
                {
                    found = true;
                    Console.WriteLine("Product Found:");
                    Console.WriteLine($"ID:       {prodID[i]}");
                    Console.WriteLine($"Name:     {prodName[i]}");
                    Console.WriteLine($"Price:    {prodPrice[i]}");
                    Console.WriteLine($"Colour:   {prodClr[i]}");
                    Console.WriteLine($"Size:     {prodsize[i]}");
                    Console.WriteLine($"Quantity: {prodQty[i]}");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine();
                Console.WriteLine("***   Product not found.   ***");
                Console.WriteLine();
            }
            returnmenu();
        }

        // function for buying product
        static void buyingProduct(string[] prodID, string[] prodName, string[] prodsize, string[] prodClr, string[] prodPrice, int[] prodQty, string[] prodSeller, ref int prodCount)
        {
            if (prodCount == 0)
            {
                Console.WriteLine();
                Console.WriteLine("***   No products available to buy.   ***");
                Console.WriteLine();
                returnmenu();

            }

            string id;
            int buyQty;

            bool found = false;

            Console.WriteLine("Enter Product ID to buy:  ");
            id = Console.ReadLine();

            for (int i = 0; i < prodCount; i++)
            {
                if (prodID[i] == id)
                {
                    found = true;

                    Console.WriteLine("\n************** Product Found ****************");

                    Console.WriteLine("Name  : " + prodName[i]);
                    Console.WriteLine("Price : " + prodPrice[i]);
                    Console.WriteLine("Size  : " + prodsize[i]);   // (You mistakenly used prodPrice in C++)
                    Console.WriteLine("Colour: " + prodClr[i]);
                    Console.WriteLine("Available Quantity: " + prodQty[i]);

                    Console.Write("Enter quantity to buy: ");


                    if (!int.TryParse(Console.ReadLine(), out buyQty))
                    {
                        Console.Clear();

                        Console.WriteLine();
                        Console.WriteLine("***   Invalid input! Please enter a valid integer.   ***");
                    }
                    else if (buyQty <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("***   Invalid quantity!   ***");
                    }
                    else if (buyQty > prodQty[i])
                    {
                        Console.WriteLine();
                        Console.WriteLine("***   Sorry! Not enough stock available.   ***");
                    }
                    else
                    {
                        prodQty[i] -= buyQty;
                        int price = int.Parse((prodPrice[i]));
                        int total = buyQty * price;

                        Console.WriteLine("\nPurchase Successful!");
                        Console.WriteLine("Total Bill: Rs. " + total);
                        Console.WriteLine("Remaining Stock: " + prodQty[i]);
                    }
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("***   Product ID not found.   ***");
            }

            returnmenu();
        }

        //-----------------------File Handling-----------------------------------
        static void LoadData(string[] user, string[] pass, int count, string SellerBuyer) // function definition to load data by file handling as a txt file
        {
            string path = "SellerBuyer.txt";
            if (File.Exists(path))
            {
                StreamReader ReadingData = new StreamReader(path);
                string record;
                int i = 0;

                while ((record = ReadingData.ReadLine()) != null && i < count)
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
            string path = "SellerBuyer.txt";
            StreamWriter WritingData = new StreamWriter(path, true);

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
            SaveData(user_S, pass_S, count, "seller.txt");
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