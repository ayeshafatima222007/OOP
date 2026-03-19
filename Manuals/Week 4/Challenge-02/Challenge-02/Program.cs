using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Challenge_02
{
    internal class Program
    {
         
        static int searchMemberID(Member[] allmembers, int totalMembers, int searchID)         //searching the id of member
        {
            for (int i = 0; i < totalMembers; i++)
            {
                if (allmembers[i].memberID == searchID)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        { 
            Member[] allmembers = new Member[100];
            int totalMembers = 0;
            
            string memberName;
            int memberID;
            int moneyInBank;
            string booktitle;
            int price;
           
            int option = 0;
            while (true)
            {
                Console.WriteLine(" ==============MENU===============");
                Console.WriteLine("1. Register Member");
                Console.WriteLine("2. Buy a book");
                Console.WriteLine("3. Modify Name");
                Console.WriteLine("4. Check Bank Balance");
                Console.WriteLine("5. View Purchase History");
                Console.WriteLine("6. Display All Info");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter Your Choice: ");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    if (option == 1)
                    {
                        if (totalMembers >= 100)
                        {
                            Console.WriteLine("Member Registration is full!");
                            continue;
                        }

                        Console.Write("Enter Member Name: ");
                        memberName = Console.ReadLine();
                        
                        Console.Write("Enter ID: ");
                        memberID = int.Parse(Console.ReadLine());

                        Console.Write("Enter money in bank: ");
                        moneyInBank = int.Parse(Console.ReadLine());
                         
                        allmembers[totalMembers] = new Member(memberName, memberID, moneyInBank);
                        totalMembers++;

                        Console.WriteLine("Member Registered! ");
                    }

                    else if (option == 2)
                    {
                        Console.WriteLine("=============BUY BOOK==========");
                        if (totalMembers == 0)
                        {
                            Console.WriteLine("Please Register First ");
                            continue;
                        }

                        Console.Write("Enter Member ID: ");
                        int searchID = int.Parse(Console.ReadLine());
                        int id = searchMemberID(allmembers, totalMembers, searchID);

                        if (id != -1)
                        {
                            Console.WriteLine("Enter book title: ");
                            booktitle = Console.ReadLine();

                            Console.WriteLine("Enter price: ");
                            price = int.Parse(Console.ReadLine());

                            allmembers[id].addboughtBooks(booktitle, price);
                        }
                        else
                        {
                            Console.WriteLine("ID not found!");
                        }
                    }

                    else if (option == 3)
                    {
                        Console.WriteLine("============MODIFY NAME==========");
                        if (totalMembers == 0)
                        {
                            Console.WriteLine("Please Register First ! ");
                            continue;
                        }

                        Console.Write("Enter Member ID: ");
                        int searchID = int.Parse(Console.ReadLine());

                        int id = searchMemberID(allmembers, totalMembers, searchID);

                        if (id != -1)
                        {
                            Console.WriteLine("Enter new name: ");
                            string n = Console.ReadLine();

                            allmembers[id].modifyName(n);
                        }
                        else
                        {
                            Console.WriteLine("ID not found!");
                        }
                    }
                    else if (option == 4)
                    {
                        //Check Bank Balance
                        Console.WriteLine("===========BANK BALANCE==========");
                        if (totalMembers == 0)
                        {
                            Console.WriteLine("Please Register First ! ");
                            continue;
                        }

                        Console.Write("Enter Member ID: ");
                        int searchID = int.Parse(Console.ReadLine());

                        int id = searchMemberID(allmembers, totalMembers, searchID);

                        if (id != -1)
                        {
                            allmembers[id].showBankBalance();
                        }
                        else
                        {
                            Console.WriteLine("ID not found!");
                        }
                    }

                    else if (option == 5)
                    { 
                        Console.WriteLine("===========HISTORY=============");
                        if (totalMembers == 0)
                        {
                            Console.WriteLine("Please Register First ! ");
                            continue;
                        }

                        Console.Write("Enter Member ID: ");
                        int searchID = int.Parse(Console.ReadLine());

                        int id = searchMemberID(allmembers, totalMembers, searchID);

                        if (id != -1)
                        {
                            allmembers[id].showboughtBooks();
                        }
                        else
                        {
                            Console.WriteLine("ID not found!");
                        }
                    }

                    else if(option==6)
                    { 
                        for(int i = 0; i < totalMembers; i++) 
    {
                            allmembers[i].displayAll();
                            Console.WriteLine("_____________________________");
                        }

                    }
                    else if(option==7)
                    {
                        Console.WriteLine("Exiting Menu!!");
                        Console.ReadKey();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Choice!!");
                    }
                }
            }
        }
    }
}
