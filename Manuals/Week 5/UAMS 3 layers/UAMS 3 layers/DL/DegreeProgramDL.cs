using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_3_layers.BL;

namespace UAMS_3_layers.DL    //we use BL here because we have to access BL classes
{
    public static class DegreeProgramDL
    {
        public static List<DegreeProgramBL> programList = new List<DegreeProgramBL>();

        public static void AddDegreeProgram(DegreeProgramBL d)
        {
            programList.Add(d);
        }
    }
}
