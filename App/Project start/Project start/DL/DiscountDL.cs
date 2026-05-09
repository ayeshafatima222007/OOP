using Project_start.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_start.DL
{
    internal class DiscountDL
    {
        public static List<DiscountBL> discountList = new List<DiscountBL>();

        public static void AddDiscount(DiscountBL d)
        {
            discountList.Add(d);
        }

        public static DiscountBL FindDiscount(string code)
        {
            foreach (DiscountBL d in discountList)
            {
                if (d.ValidateCode(code)) // which method validates the code?
                {
                    return d;
                }
            }
            return null;
        }

        public static List<DiscountBL> getAllDiscounts()
        {
            return discountList;
        }
    }
}
