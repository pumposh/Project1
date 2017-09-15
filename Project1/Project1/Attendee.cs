using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Attendee
    {
        private string attendee_name;

        public string Attendee_name
        {
            get { return attendee_name; }
            set { attendee_name = value; }
        }

 
        private string event_name;

        public string Event_name
        {
            get { return event_name; }
            set { event_name = value; }
        }
        private string available_time;

        public string Available_time
        {
            get { return available_time; }
            set { available_time = value; }
        }
    }
}
