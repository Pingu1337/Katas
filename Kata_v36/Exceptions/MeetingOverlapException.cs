using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scheduler.Models;

namespace Scheduler.Exceptions
{
    class MeetingOverlapException : SystemException
    {
        public MeetingOverlapException(Meeting overlappingMeeting) : base("Overlapping meeting " + overlappingMeeting)
        {
        }
    }
}
