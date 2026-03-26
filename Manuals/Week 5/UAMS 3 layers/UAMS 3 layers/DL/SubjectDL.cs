using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;

namespace UAMS_3_layers.DL    //we use BL here because we have to access BL classes
{
    public static class SubjectDL
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
