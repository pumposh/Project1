using System;
using System.Collections.Generic;

namespace Project1
{
    public class Event
    {
        public String name { get; private set; }
        public String host { get; private set; }
        public DateTime date { get; private set; }
        public DateTime[] times { get; private set; }
        public List<Attendee> attendees = new List<Attendee>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <param name="Name">The name.</param>
        /// <param name="Date">The date.</param>
        /// <param name="Times">The times.</param>
        public Event(string Host, string Name, DateTime Date, DateTime[] Times)
        {
            name = Name;
            host = Host;
            date = Date;
            times = Times;
            attendees.Add(new Attendee(host, this, times));
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return name + " on " + date.ToString("MM/dd/yyyy");
        }
    }
}
