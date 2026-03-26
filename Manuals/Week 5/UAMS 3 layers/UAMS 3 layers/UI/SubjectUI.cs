using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;

namespace UAMS_3_layers.UI
{
    public static class SubjectUI
    {
        public static SubjectBL TakeSubjectInput()
        {
            Console.Write("Enter Subject Code:");
            string code = Console.ReadLine();

            int CreditHr;
            while (true)
            {
                Console.Write("Enter Subject Credit Hours:");
                if (int.TryParse(Console.ReadLine(), out CreditHr))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Credit Hour!!");
                }
            }

            Console.Write("Enter Subject Type:");
            string type = Console.ReadLine();

            float SubjFee;
            while (true)
            {
                Console.Write("Enter Subject Fees:");
                if (float.TryParse(Console.ReadLine(), out SubjFee))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter Valid Fees!!");
                }
            }

            SubjectBL s = new SubjectBL(code, CreditHr, type, SubjFee);
           
            return s;
        }
    }
}
