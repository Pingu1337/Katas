using System;

namespace Scheduler.Models
{
    public class Meeting
    {
        public DateTime Start;
        public TimeSpan Duration;
        public Applicant Applicant;

        public Meeting(DateTime start)
        {
            Start = start;
            Duration = TimeSpan.FromMinutes(30);
            Applicant = null;
        }
        public Meeting(DateTime start, TimeSpan duration)
        {
            Start = start;
            Duration = duration;
            Applicant = null;
        }

        public bool Overlap(Meeting meeting)
        {
            bool endIsBefore = (Start + Duration) < meeting.Start;
            bool startIsAfter = (meeting.Start + meeting.Duration) < Start;

            return !(endIsBefore || startIsAfter);
        }

        public override string ToString()
        {
            //string date = Start.ToLongDateString() +" "+ Start.ToString("H:mm") + "-" + Start.ToString("H:") + Duration.ToString("%m");
            string date = Start.ToLongDateString() + " " + Start.ToString("HH:mm") + "-" + Start.Add(Duration).ToString("HH:mm");
            //string date = Start.ToString("d'/'M'/'yy");

            string info = date + " ";

            if (Applicant != null)
                info += " with: " + Applicant.Name;

            return info;
        }
    }
}
