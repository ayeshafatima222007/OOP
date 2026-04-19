using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Management_System
{
    internal class MenuItem
    {
        public string Name;
        public string Type;
        public int Price;

        public MenuItem(string Name, string Type, int Price)
        {
            this.Name = Name;
            this.Type = Type;
            this.Price = Price;

        }

    }
}
