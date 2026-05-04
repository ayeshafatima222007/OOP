using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_and_Paragraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document("My Document");
            doc.AddPara("This is first paragraph.");
            doc.AddPara("This is second paragraph.");
            doc.Print();
        }
    }
}
