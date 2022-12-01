using MeetingTask.Models;

namespace MeetingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.SetMeeting("qonaqliq", new DateTime(2022, 2, 3), new DateTime(2022, 2, 5));
            meetingSchedule.SetMeeting("qonaqliq1", new DateTime(2022, 2, 8), new DateTime(2022, 2, 9));
            meetingSchedule.SetMeeting("qonaqliq2", new DateTime(2022, 2, 7), new DateTime(2022, 2, 5));
            meetingSchedule.SetMeeting("qonaqliq4", new DateTime(2022, 2, 6), new DateTime(2022, 2, 7));
            
        }
    }
}