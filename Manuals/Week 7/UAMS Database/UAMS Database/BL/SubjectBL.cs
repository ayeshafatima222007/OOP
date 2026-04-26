using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS_Database.BL
{
    internal class SubjectBL
    {
        public string SubjCode;
        public int CRH;
        public string SubjType;
        public float SubjFee;

        public SubjectBL(string SubjCode, int CRH, string SubjType, float SubjFee)
        {
            this.SubjCode = SubjCode;
            this.CRH = CRH;
            this.SubjType = SubjType;
            this.SubjFee = SubjFee;

        }
    }
}
