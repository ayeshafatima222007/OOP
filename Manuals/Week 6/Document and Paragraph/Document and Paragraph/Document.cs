using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_and_Paragraph
{
    internal class Document
    {
        private string title;
        private List<Paragraph> paraList;

        public Document(string title) 
        {
            this.title = title;
            paraList = new List<Paragraph>();
        }

        public void AddPara(string Content)
        {
            paraList.Add(new Paragraph (Content));
        }

        public void Print() 
        {
            Console.WriteLine($"Document: {title}");
            foreach (Paragraph para in paraList)
            {
                para.Print();
            }
        }
    }
}
