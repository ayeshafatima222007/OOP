using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Application
{
    internal class WorkoutRoutine
    {
        private string WRName;
        private List<Exercise> Exrlist;

        public WorkoutRoutine(string WRName)
        {
            this.WRName = WRName;
            this.Exrlist = new List<Exercise>();
        }

        public string getWRName()
        {
            return WRName;
        }

        public void setWRName(string WRName)
        {
            this.WRName = WRName;
        }

        public List<Exercise> getExercises()
        {
            return Exrlist;
        }
        public void AddExercise(Exercise ex)
        {
            Exrlist.Add(ex);
        }

    }
}
