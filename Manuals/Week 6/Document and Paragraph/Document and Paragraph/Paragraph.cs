using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_and_Paragraph
{
    internal class Paragraph
    {
        private string content;
        public Paragraph(string content) 
        {
            this.content = content;
        }

        public void Print()
        {
            Console.WriteLine(content);
        }
    }
}
