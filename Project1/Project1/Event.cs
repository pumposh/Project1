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
        public DateTime date { get; private set; }
        /// <summary>
        /// Gets the times.
        /// </summary>
        /// <value>
        /// The times.
        /// </value>
        public DateTime[] times { get; private set; }
        /// <summary>
        /// The attendees
        /// </summary>
        public List<Attendee> attendees = new List<Attendee>();
		/// <summary>
		/// The Task List
		/// </summary>
		public List<string> taskList = new List<string>(); //&&&

        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <param name="Name">The name.</param>
        /// <param name="Date">The date.</param>
        /// <param name="Times">The times.</param>
        public Event(string Host, string Name, DateTime Date, DateTime[] Times, List<string> TaskList)
        {
            name = Name;
            host = Host;
            date = Date;
            times = Times;
            taskList = TaskList;
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
