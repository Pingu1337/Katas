using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using Scheduler.Exceptions;

namespace Scheduler.Models
{
    public class CaseWorker
    {
        public void TimeKeeper()
        {
            Meeting keepTime = new Meeting(Meetings.Last().Start, Meetings.Last().Duration);
            TimeSpan thirty = new TimeSpan(0, 30, 0);
            startTimeKeeperDateTime = (keepTime.Start);
            durationTimeKeeperDateTime = (keepTime.Duration);
            foreach (Meeting meeting in Meetings)
            {
                if (meeting.Overlap(keepTime))
                {
                   keepTime.Start += new TimeSpan(30);
                }
                startTimeKeeperDateTime = (keepTime.Start);
                durationTimeKeeperDateTime = (keepTime.Duration);
            }
        }

        public string Name;
        public List<Meeting> Meetings;
        public DateTime startTimeKeeperDateTime;
        public TimeSpan durationTimeKeeperDateTime;
        


        public CaseWorker()
        {
            Meetings = new List<Meeting>();

            DateTime startOfWork = DateTime.Today.AddHours(8);
            for (int i = 0; i < 6; i++)
            {
                DateTime startOfMeeting = startOfWork.AddHours(i);
                Meeting meeting = new Meeting(startOfMeeting);

                Meetings.Add(meeting);
            }
        }

        public void NewDateAdded(DateTime start)
        {
            Meeting newMeeting = new Meeting(start);

            // TODO kasta MeetingOverlapException om två möten överlappar

            foreach (Meeting meeting in Meetings)
            {
                if (meeting.Overlap(newMeeting))
                {
                    throw new MeetingOverlapException(meeting);
                }
                
            }
            Meetings.Add(newMeeting);
        }

        public void ChangeMeeting(int index, DateTime newStart)
        {
            Meeting meetingToChange = Meetings[index];
            Meeting attemptMeeting = new Meeting(newStart, meetingToChange.Duration);

            foreach (Meeting meeting in Meetings)
            {
                if (meeting.Overlap(attemptMeeting))
                {
                    throw new MeetingOverlapException(meeting);
                }
                if (meeting == meetingToChange)
                    continue;

                // TODO kasta MeetingOverlapException om två möten överlappar
            }

            meetingToChange.Start = newStart;
        }

        public void MoveUpMeeting()
        {
            Meeting attemptMoveMeeting = new Meeting(startTimeKeeperDateTime, durationTimeKeeperDateTime);
            Meeting moveMeeting = new Meeting(attemptMoveMeeting.Start, attemptMoveMeeting.Duration);
            
            Debug.WriteLine("startKeepTime: " + startTimeKeeperDateTime);
            Debug.WriteLine("durationKeepTime: " + durationTimeKeeperDateTime);
            Debug.WriteLine("Result: " + attemptMoveMeeting);
            Debug.WriteLine("[1] Input Value: " + moveMeeting);

            foreach (Meeting meeting in Meetings)
            {
                if (meeting.Overlap(moveMeeting))
                {
                     moveMeeting.Start += TimeSpan.FromMinutes(30);
                     Debug.WriteLine("[*!*]OVERLAP DETECTED IN FIRST[1] FOREACH[*!*] \n Start: " + moveMeeting.Start + "\n Duration: " + moveMeeting.Duration);
                }
            }

            foreach (Meeting meeting in Meetings)
            {

                moveMeeting = moveMeeting;
                    Debug.WriteLine("[2] Value in second foreach: " + moveMeeting);

                    /* if (meeting.Overlap(MoveAttempt))
                     {
                         attemptMoveMeeting.Start += TimeSpan.FromMinutes(30);
                         Debug.WriteLine("[*!*]OVERLAP DETECTED IN SECOND[2] FOREACH[*!*] \n VALUE: " + attemptMoveMeeting.Start);
                     }*/

            }

            Meeting moveMeetingFinal = moveMeeting;
            Debug.WriteLine("[3]Adding this to Meetings= " + moveMeetingFinal);
            Meetings.Add(moveMeetingFinal);

        }

        
    }
}
