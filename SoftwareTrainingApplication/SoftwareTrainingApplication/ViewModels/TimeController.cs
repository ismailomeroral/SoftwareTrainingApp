using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTrainingApplication.ViewModels
{
    internal class TimeController
    {
        int Hours = 0;
        int Minutes = 0;
        int Seconds = 0;
        public void timeFlowingForward(int count)
        {
            Seconds += count;
            if (Seconds > 59)
            {
                Minutes++;
                Seconds = 0;
            }
            if (Minutes > 59)
            {
                Hours++;
                Minutes = 0;
            }
        }
        public void timeFlowingBackward(int count)
        {
            Seconds -= count;
            if (Seconds < 0)
            {
                Seconds = 59;
                Minutes--;
            }
            if (Minutes < 0)
            {
                Minutes = 59;
                Hours--;
            }
        }
        public bool IsFinishTime()
        {
            return (Seconds <= 0 && Minutes <= 0 && Hours <= 0);
        }

        public string TimerExport()
        {
            return Hours.ToString("00") + ":" + Minutes.ToString("00") + ":" + Seconds.ToString("00");
        }
        public void TimeSet(int _hour, int _minute)
        {
            Hours = _hour + (_minute - (_minute % 60)) / 60;
            Minutes = (_minute % 60);
            Seconds = 0;
        }
    }
}
