using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universit_Management_System
{
    internal class Degree
    {
        public string title;
        public float duration;
        public int seats;

        public List<Subject> subjects;

        public Degree(string title, float duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<Subject>();
        }
        public int calculateCreditHours()
        {
            int total = 0;
            foreach (Subject subject in subjects) 
            {
                total = total + subject.CRH;
                
            }
            return total;

        }
        public bool isSubjectExists(Subject sub)
        {
            foreach (Subject subject in subjects)
            {
                if (subject.SubjCode == sub.SubjCode)
                {
                    return true;
                }
            }
            return false;

        }

        public bool AddSubject(Subject s)
        {
            int creditHours = calculateCreditHours();
            if (creditHours + s.CRH <= 20)
            {
                subjects.Add(s);
                return true;
            }
            return false;
             
        }
    }
}
