using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class event_description
    {
        private String eventname;

        public String Eventname
        {
            get { return eventname; }
            set { eventname = value; }
        }
        private String eventcreator;

        public String Eventcreator
        {
            get { return eventcreator; }
            set { eventcreator = value; }
        }
        private String event_date;

        public String Event_date
        {
            get { return event_date; }
            set { event_date = value; }
        }
        private String event_starttime;

        public String Event_starttime
        {
            get { return event_starttime; }
            set { event_starttime = value; }
        }
        private String event_endtime;

        public String Event_endtime
        {
            get { return event_endtime; }
            set { event_endtime = value; }
        }
    }
}
