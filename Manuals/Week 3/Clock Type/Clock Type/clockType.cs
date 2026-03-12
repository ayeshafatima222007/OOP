using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Type
{
    internal class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public clockType(int hrs, int mins, int sec)
        {
            hours = hrs;
            minutes = mins;
            seconds = sec;
        }

        public int ElapsedTime()
        {
            return ((hours * 3600) + (minutes * 60) + seconds);
        }
         
        public int RemainingTime()
        {
            int totalSeconds = 24 * 3600;
            return totalSeconds - ElapsedTime();
        }

        public int Difference(clockType otherClock)
        {
            int t1 = this.ElapsedTime();
            int t2 = otherClock.ElapsedTime();

            return Math.Abs(t1 - t2);
        }

        public void DisplayTime()
        {
            Console.WriteLine(hours + " : " + minutes + " : " + seconds);
        }
    }

}
