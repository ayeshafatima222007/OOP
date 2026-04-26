using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Database.BL
{
    internal class DegreeProgramBL
    {
        private string title;
        private float duration;
        private int seats;
        private List<SubjectBL> subjects;

        public DegreeProgramBL(string title, float duration, int seats)
        {
            this.title = title;
            this.duration = duration;
            this.seats = seats;
            subjects = new List<SubjectBL>();
        }

        public void SetTitle(string title) { this.title = title; }
        public string GetTitle() { return title; }

        public void SetDuration(float duration) { this.duration = duration; }
        public float GetDuration() { return duration; }

        public void SetSeats(int seats) { this.seats = seats; }
        public int GetSeats() { return seats; }

        public void SetSubjects(List<SubjectBL> subjects) { this.subjects = subjects; }
        public List<SubjectBL> GetSubjects() { return subjects; }

        public int CalculateCreditHours()
        {
            int total = 0;
            foreach (SubjectBL subject in subjects)
                total += subject.GetCRH();
            return total;
        }

        public bool IsSubjectExists(SubjectBL sub)
        {
            foreach (SubjectBL subject in subjects)
                if (subject.GetSubjCode() == sub.GetSubjCode())
                    return true;
            return false;
        }

        public bool AddSubject(SubjectBL s)
        {
            if (CalculateCreditHours() + s.GetCRH() <= 20)
            {
                subjects.Add(s);
                return true;
            }
            return false;
        }
    }
}
