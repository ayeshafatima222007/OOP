using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;

namespace UAMS_Database.DL
{
    internal class SubjectDL
    {
        public static SubjectBL FindByCode(List<SubjectBL> subjects, string code)
        {
            foreach (SubjectBL s in subjects)
                if (s.SubjCode == code)
                    return s;
            return null;
        }
    }
}
