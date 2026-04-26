using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Database.BL
{
    internal class SubjectBL
    {
        private string subjCode;
        private int crh;
        private string subjType;
        private float subjFee;

        public SubjectBL(string subjCode, int crh, string subjType, float subjFee)
        {
            this.subjCode = subjCode;
            this.crh = crh;
            this.subjType = subjType;
            this.subjFee = subjFee;
        }

        public void SetSubjCode(string subjCode) { this.subjCode = subjCode; }
        public string GetSubjCode() { return subjCode; }

        public void SetCRH(int crh) { this.crh = crh; }
        public int GetCRH() { return crh; }

        public void SetSubjType(string subjType) { this.subjType = subjType; }
        public string GetSubjType() { return subjType; }

        public void SetSubjFee(float subjFee) { this.subjFee = subjFee; }
        public float GetSubjFee() { return subjFee; }
    }
}
