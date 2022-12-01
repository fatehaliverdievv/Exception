using MeetingTask.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingTask.Models
{
    internal class MeetingSchedule
    {
        Meeting[] meeting;
        public MeetingSchedule()
        {
            meeting = new Meeting[0];
        }

        public void SetMeeting(string fullname , DateTime fromdate, DateTime todate )
        {
            try
            {
                if (meeting.Length == 0)
                {
                    if (fromdate <= todate)
                    {
                        Array.Resize(ref meeting, meeting.Length + 1);
                        Meeting meetings = new Meeting(fullname, fromdate, todate);
                        meeting[meeting.Length - 1] = meetings;
                    }
                    else
                    {
                        throw new WrongDateIntervalException("Wronge Date Time !!");
                    }
                }
                else
                {
                    if (fromdate <= todate)
                    {
                        for (int i = 0; i < meeting.Length; i++)
                        {
                                if (!((meeting[i].FromDate > fromdate && meeting[i].FromDate > todate) || (meeting[i].ToDate < fromdate && meeting[i].ToDate < todate)))
                                {
                                    throw new ReservedDateIntervalException("Already reserved");
                                }
                        }
                        Array.Resize(ref meeting, meeting.Length + 1);
                        Meeting meetings = new Meeting(fullname, fromdate, todate);
                        meeting[meeting.Length - 1] = meetings;
                    }
                    else
                    {
                        throw new WrongDateIntervalException("Wronge Date Time !!");
                    }
                }

            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }

        }
        public void GetMeetingInfo()
        {
            foreach (var item in meeting)
            {
                Console.WriteLine(item.Fullname);
            }
        }
    }
}