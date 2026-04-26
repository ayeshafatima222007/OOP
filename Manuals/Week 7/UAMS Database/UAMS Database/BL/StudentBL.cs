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
        private string name;
        private int age;
        private float fscMarks;
        private float ecatMarks;
        private double merit;
        private List<DegreeProgramBL> preferences;
        private List<SubjectBL> regSubj;
        private DegreeProgramBL regDegree;

        public StudentBL(string name, int age, float fscMarks, float ecatMarks)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.merit = 0;
            this.regDegree = null;
            preferences = new List<DegreeProgramBL>();
            regSubj = new List<SubjectBL>();
        }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }

        public void SetAge(int age) { this.age = age; }
        public int GetAge() { return age; }

        public void SetFSCMarks(float fscMarks) { this.fscMarks = fscMarks; }
        public float GetFSCMarks() { return fscMarks; }

        public void SetECATMarks(float ecatMarks) { this.ecatMarks = ecatMarks; }
        public float GetECATMarks() { return ecatMarks; }

        public double GetMerit() { return merit; }

        public void SetPreferences(List<DegreeProgramBL> preferences) { this.preferences = preferences; }
        public List<DegreeProgramBL> GetPreferences() { return preferences; }

        public void SetRegSubj(List<SubjectBL> regSubj) { this.regSubj = regSubj; }
        public List<SubjectBL> GetRegSubj() { return regSubj; }

        public void SetRegDegree(DegreeProgramBL regDegree) { this.regDegree = regDegree; }
        public DegreeProgramBL GetRegDegree() { return regDegree; }

        public void CalculateMerit()
        {
            merit = (fscMarks * 0.30) + (ecatMarks * 0.70);
        }

        public int GetCreditHours()
        {
            int total = 0;
            foreach (SubjectBL subject in regSubj)
                total += subject.GetCRH();
            return total;
        }

        public float CalculateFee()
        {
            float total = 0;
            foreach (SubjectBL subject in regSubj)
                total += subject.GetSubjFee();
            return total;
        }

        public bool StdRegSubj(SubjectBL s)
        {
            int stdCH = GetCreditHours();
            if (regDegree != null && regDegree.IsSubjectExists(s) && stdCH + s.GetCRH() <= 9)
            {
                regSubj.Add(s);
                return true;
            }
            return false;
        }
    }
}
