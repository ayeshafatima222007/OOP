using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Application
{
    internal class Set
    {
        private int reps;
        private double weight;

        public Set(int reps, double weight)
        {
            this.reps = reps;
            this.weight = weight;
        }

        public int getReps()
        {
            return reps;
        }
        public void setReps(int reps)
        {
            this.reps = reps;
        }
        public double getWeight()
        {
            return weight;
        }
        public void setWeight(double weight)
        {
            this.weight = weight;
        }

    }
}
