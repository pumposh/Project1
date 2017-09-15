using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Attendee
    {
        public string name { get; private set; }
        public Event ev { get; private set; }
        public DateTime[] availableTimes { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attendee"/> class.
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
