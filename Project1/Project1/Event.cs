using System;
using System.Collections.Generic;

namespace Project1
{
    internal class Event
    {
        public string host { get; private set; }
        public string name { get; private set; }.
        public DateTime date { get; private set; }
        public DateTime[] times { get; private set;  }
        internal List<Attendee> attendees = new List<Attendee>();

        public Event()//add params
        {

        }

        public override string ToString()
        {
            return base.ToString(); //output formatting
        }
    }
}