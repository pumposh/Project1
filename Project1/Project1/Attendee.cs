using System;

namespace Project1
{
    /// <summary>
    /// Attendee class
    /// </summary>
    public class Attendee
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; private set; }
        /// <summary>
        /// Gets the ev.
        /// </summary>
        /// <value>
        /// The ev.
        /// </value>
        public Event ev { get; private set; }
        /// <summary>
        /// Gets the available times.
        /// </summary>
        /// <value>
        /// The available times.
        /// </value>
        public DateTime[] availableTimes { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attendee" /> class.
        /// </summary>
        /// <param name="Name">The name.</param>
        /// <param name="Ev">The ev.</param>
        /// <param name="AvailableTimes">The available times.</param>
        public Attendee(string Name, Event Ev, DateTime[] AvailableTimes)
        {
            name = Name;
            ev = Ev;
            availableTimes = AvailableTimes;
        }
    }
}
