using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingTask.Models
{
    internal class Meeting
    {
        public string Fullname { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public object SetMeeting { get; internal set; }

        public Meeting(string fullname, DateTime fromDate, DateTime toDate)
        {
            this.Fullname = fullname;
            this.FromDate=fromDate;
            this.ToDate=toDate;
        }
    }
}
