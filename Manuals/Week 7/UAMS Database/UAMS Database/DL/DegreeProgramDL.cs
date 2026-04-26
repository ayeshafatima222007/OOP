using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS_Database.BL;

namespace UAMS_Database.DL
{
    internal class DegreeProgramDL
    {
        public static List<DegreeProgramBL> programList = new List<DegreeProgramBL>();

        public static void AddDegreeProgram(DegreeProgramBL d)
        {
            programList.Add(d);
        }
    }
}
