using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb03
{
    internal class EnumTypeEx
    {
        [Flags]
        public enum Days
        {
            None = 0,
            Monday=1,
            Tuseday=2,
            Wednesday=4,
            Thursday=8,
            Friday=16,
            Saturday=32,
            Sunday=64,
            weekends=Saturday|Sunday,
        }
        public void dayMeeting()
        {
            Days meetingDays = Days.Monday | Days.Tuseday | Days.Wednesday;
            Console.WriteLine(meetingDays);

            Days workFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine(workFromHomeDays);

            bool isMetting = (meetingDays & Days.Saturday) == Days.Saturday;
            Console.WriteLine(isMetting);

            var a =(Days)6;
            Console.WriteLine(a);
        }
    }
}
