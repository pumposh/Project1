using System;
using System.Collections.Generic;

namespace Project1
{
    /// <summary>
    /// Event class
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String name { get; private set; }
        /// <summary>
        /// Gets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public String host { get; private set; }
        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public DateTime[] dateTimes { get; private set; }
        /// <summary>
        /// The attendees
        /// </summary>
        public List<Attendee> attendees = new List<Attendee>();

        /// <summary>
        /// The Task List
        /// </summary>
        public List<string> taskList = new List<string>();

		/// <summary>
		/// Initializes a new instance of the <see cref="Event" /> class.
		/// </summary>
		/// <param name="Host">The host.</param>
		/// <param name="Name">The name.</param>
		/// <param name="DateTimes">The dates and times.</param>
		/// <param name="TaskList">The list of tasks.</param>
        public Event(string Host, string Name, DateTime[] DateTimes, List<string> TaskList)
		{
			name = Name;
			host = Host;
			dateTimes = DateTimes;
			taskList = TaskList;
            attendees.Add(new Attendee(host, this, dateTimes, new List<string>()));
		}

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            String builder = name + " on ";

            for (int i = 0; i < dateTimes.Length; i++)
            {
                if (i == 0)
                {
                    builder += dateTimes[i].ToString("MM/dd/yyyy");
				}
                else if (!(dateTimes[i].ToString("MM/dd/yyyy").Equals(dateTimes[i - 1].ToString("MM/dd/yyyy"))))
                {
                    builder += ", " + dateTimes[i].ToString("MM/dd/yyyy");
				}
			}

            return builder;
        }
    }
}
