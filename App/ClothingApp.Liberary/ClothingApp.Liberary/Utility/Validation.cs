using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingApp.Library.Utility
{
    public static class Validation
    {
        public static bool IsNullOrEmpty(string value)       // --- Null-mpty ---
        {
            return string.IsNullOrWhiteSpace(value);
        }


        //********************     VALIDATION CHECK FOR SIGN UP/SIGN IN      ********************
         
        public static bool IsValidUsername(string username)        // --- Username ---
        {
            if (IsNullOrEmpty(username))
            {
                return false;
            }
            if (username.Length < 3 || username.Length > 20)      //username can;t be less then 3 and not greater than 20
            {
                return false;
            }

            bool hasNumber = false;
            bool hasUnderscore = false;

            for (int i = 0; i < username.Length; i++)
            {
                if (!((username[i] >= 'a' && username[i] <= 'z') ||
                      (username[i] >= 'A' && username[i] <= 'Z') ||
                      (username[i] >= '0' && username[i] <= '9') ||
                      (username[i] == '_')))                        //allow small alphabet,large alphabet,any number,underscore
                {
                    return false;
                }

                //validating number or underscore
                if (username[i] >= '0' && username[i] <= '9')
                {
                    hasNumber = true;
                }
                else if (username[i] == '_')
                {
                    hasUnderscore = true;
                }
            }

            return hasNumber && hasUnderscore;
        }

        // --- Password ---
        public static bool IsValidPassword(string password)
        {
            if (IsNullOrEmpty(password)) return false;
            if (password.Length < 5 || password.Length > 8) return false;

            bool hasSpecial = false;
            bool hasNumber = false;
            bool hasUpper = false;
            bool hasLower = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    hasSpecial = true;
                }
                else if (password[i] >= '0' && password[i] <= '9')
                {
                    hasNumber = true;
                }
                else if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    hasUpper = true;
                }
                else if (password[i] >= 'a' && password[i] <= 'z')
                {
                    hasLower = true;
                }
            }

            return hasSpecial && hasNumber && hasUpper && hasLower;
        }

        // --- Phone Number ---
        public static bool IsValidPhone(string phone)
        {
            if (IsNullOrEmpty(phone))
            {
                return false;
            }
            if (phone.Length != 11)
            {
                return false;
            }
            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] < '0' || phone[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }

        // --- Address ---
        public static bool IsValidAddress(string address)
        {
            if (IsNullOrEmpty(address))
            {
                return false;
            }
            return address.Length >= 5;
        }


        //********************     VALIDATION CHECK FOR PRODUCT     ********************

        // --- Product Id ---
        public static bool IsValidProductId(string productId)
        {
            if (IsNullOrEmpty(productId))
            {
                return false;
            }
            return true;
        }

        // --- Category ---
        public static bool IsValidCategory(string category)     //also use for tax
        {
            if (IsNullOrEmpty(category))
            {
                return false;
            }
            return category == "Casual" || category == "Formal" || category == "Embroidered" || category == "Sports";
        }

        // --- Name ---
        public static bool IsValidName(string name)
        {
            if (IsNullOrEmpty(name))
            {
                return false;
            }
            return true;
        }

        // --- color ---
        public static bool IsValidColor(string color)
        {
            if (IsNullOrEmpty(color))
            {
                return false;
            }
            return true;
        }


        // --- Size ---
        public static bool IsValidSize(string size)
        {
            if (IsNullOrEmpty(size))
            {
                return false;
            }
            string s = size.ToUpper();
            return s == "S" || s == "M" || s == "L";
        }

        // --- Price ---
        public static bool IsValidPrice(double price)
        {
            return price > 0;
        }

        // --- Quantity ---
        public static bool IsValidQuantity(int quantity)
        {
            return quantity > 0;
        }

        //***************      VALIDATION CHECK FOR PAYMENT     ********************

        // --- Amount ---
        public static bool IsValidAmount(double amount)
        {
            return amount > 0;
        }

        // --- Payment Method ---
        public static bool IsValidPaymentMethod(string method)
        {
            if (IsNullOrEmpty(method))
            {
                return false;
            }
            return method == "Cash" || method == "Card" || method == "Online";
        }

        //
        public static bool IsValidOrderStatus(string status)
        {
            return status == "Pending" || status == "Processing" || status == "Shipped" || status == "Delivered" || status == "Cancelled";
        }

        //***************      VALIDATION CHECK FOR DISCOUNT     ********************

        // --- Discount Percent ---
        public static bool IsValidDiscountPercent(double percent)       //also valid for tax
        {
            return percent >= 5 && percent <= 50;
        }

        // --- Discount Code ---
        public static bool IsValidDiscountCode(string code)
        {
            return !IsNullOrEmpty(code);
        }


        //***************      VALIDATION CHECK FOR DELIVERY    ********************
        public static bool IsValidDeliveryMethod(string method)
        {
            if (IsNullOrEmpty(method))
            {
                return false;
            }
            return method == "Pickup" || method == "HomeDelivery";
        }
    }
}
