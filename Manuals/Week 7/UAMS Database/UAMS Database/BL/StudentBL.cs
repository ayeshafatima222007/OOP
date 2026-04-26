using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;

namespace UAMS_Database
{
    internal class StudentBL
    {
        public string Name;
        public int age;
        public float FSCMarks;
        public float ECATMarks;
        public double merit;

        public List<DegreeProgramBL> prefrences;
        public List<SubjectBL> RegSubj;

        public DegreeProgramBL RegDegree;


        public StudentBL(string Name, int age, float FSCMarks, float ECATMarks)
        {
            this.Name = Name;
            this.age = age;
            this.FSCMarks = FSCMarks;
            this.ECATMarks = ECATMarks;
            this.merit = 0;
            this.RegDegree = null;

            prefrences = new List<DegreeProgramBL>();
            RegSubj = new List<SubjectBL>();
        }
        public void CalculateMerit()
        {
            merit = (FSCMarks * 0.30) + (ECATMarks * 0.70);
        }

        public int GetCreditHours()
        {

            int total = 0;
            foreach (SubjectBL subject in RegSubj)
            {
                total = total + subject.CRH;

            }
            return total;

        }

        public float CalculateFee()
        {
            float total = 0;
            foreach (SubjectBL subject in RegSubj)
            {
                total = total + subject.SubjFee;

            }
            return total;

        }

        public bool StdRegSubj(SubjectBL s)
        {
            int StdCH = GetCreditHours();

            if (RegDegree != null && RegDegree.isSubjectExists(s) && StdCH + s.CRH <= 9)
            {
                RegSubj.Add(s);
                return true;
            }
            return false;
        }
    }
}
