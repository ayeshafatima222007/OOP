using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Database.BL
{
    internal class DegreeProgramBL
    {
        public string title;
        public float duration;
        public int seats;

        public List<SubjectBL> subjects;

        public DegreeProgramBL(string title, float duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<SubjectBL>();
        }
        public int calculateCreditHours()
        {
            int total = 0;
            foreach (SubjectBL subject in subjects)
            {
                total = total + subject.CRH;

            }
            return total;

        }
        public bool isSubjectExists(SubjectBL sub)
        {
            foreach (SubjectBL subject in subjects)
            {
                if (subject.SubjCode == sub.SubjCode)
                {
                    return true;
                }
            }
            return false;

        }

        public bool AddSubject(SubjectBL s)
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
