using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSetter.Timing
{
    class Timing
    {
        public int Timer = 0;

        public int setTimerHours(int h, int? m, int? s )
        {
            return 60 * h;
        } 

        public int getTimer(int time)
        {
            return this.Timer = time;
        }



    }
}
