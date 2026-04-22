using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Application
{
    internal class Exercise
    {
        private string ExrName;
        private List<Set> setlist;

        public Exercise(string ExrName)
        {
            this.ExrName = ExrName;
            this.setlist = new List<Set>();
        }

        public string getExrName()
        {
            return ExrName;
        }

        public void setExrName(string ExrName)
        {
            this.ExrName = ExrName;
        }

        public List<Set> getSets()
        {
            return setlist;
        }

        public void AddSet(Set s)
        {
            setlist.Add(s);
        }


    }
}
