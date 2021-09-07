using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Models;

namespace Scheduler.Exceptions
{
    class MeetingDuringLunchException : SystemException
    {
        
        public MeetingDuringLunchException(Meeting duringLunchMeeting) : base("Unable to schedule meeting during lunch: " + duringLunchMeeting.Start.ToString("H:mm") + "-" + duringLunchMeeting.Start.Add(duringLunchMeeting.Duration).ToString("HH:mm"))
        {
        }
    }
}

