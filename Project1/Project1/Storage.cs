using System;
using System.IO;

namespace Project1
{
    internal class Storage
    {
        /// <summary>
        /// Formats a DateTime array into a string
        /// </summary>
        /// <param name="times">The times.</param>
        /// <param name="mode24">if set to <c>true</c> [mode24].</param>
        /// <returns></returns>
        internal static String TimesFormatted(DateTime[] times, bool mode24 = false)
        {
            string builder = string.Empty;
            if (times.Length == 0)
                return builder;

            for(int i = 0; i < times.Length - 1; i++)
            {
                if(mode24)
                    builder += times[i].ToString("HH:mm") + ",";
                else
                builder += times[i].ToString("hh:mm tt") + ",";
            }
            if (mode24)
                builder += times[times.Length - 1].ToString("HH:mm");
            else
                builder += times[times.Length - 1].ToString("hh:mm tt");
            return builder;
        }

        /// <summary>
        /// Reads the times.
        /// </summary>
        /// <param name="times">The times.</param>
        /// <returns></returns>
        private static DateTime[] ReadTimes(string[] times)
        {
            if (times.Length == 0)
                return new DateTime[0];
            DateTime[] dTimes = new DateTime[times.Length];

            for(int i = 0; i < times.Length; i++)
            {
                dTimes[i] = DateTime.Parse(times[i]);
            }
            return dTimes;
        }

        /// <summary>
        /// Adds Event to file.
        /// Output Format: user_name    event_name  event_time  [times available] separated by a ,
        /// </summary>
        /// <param name="ev">The ev.</param>
        internal static void AddEvent(Event ev)
        {
            //Write a value to the specified path
            //Create IO stream
            FileStream iOflow = new FileStream(Environment.CurrentDirectory + "\\record.txt", FileMode.Append);
            //Create a writer
            StreamWriter writer = new StreamWriter(iOflow);
            //Writes the specified content to the file
            writer.WriteLine(ev.host + "\t" + ev.name + "\t" + ev.date.ToString("MM/dd/yyyy") + "\t" + TimesFormatted(ev.times));
            //Close the writer
            writer.Close();
            //Close the file stream
            iOflow.Close();
        }

        /// <summary>
        /// Adds the attendee to file.
        /// Format: attendeeName    eventName   [times]
        /// </summary>
        /// <param name="attendee">The attendee.</param>
        internal static void AddAttendee(Attendee attendee)
        {
            //Write a value to the specified path
            //Create IO stream
            FileStream iOflow = new FileStream(Environment.CurrentDirectory + "\\recordattendee.txt", FileMode.Append);
            //Create a writer
            StreamWriter writer = new StreamWriter(iOflow);
            //Writes the specified content to the file
            //writer.WriteLine("nameBox:" + user_name + "\teventNameBox:" + event_name + "\teventTime:" + eventTime);
            writer.WriteLine(attendee.name + "\t" + attendee.ev.name + "\t" + TimesFormatted(attendee.availableTimes));
            //Close the writer
            writer.Close();
            //Close the file stream
            iOflow.Close();
        }


        /// <summary>
        /// Reads attendee from a string array
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        internal static Attendee ReadAttendee(string[] items)
        {
            if (items.Length != 3)
                return null;
            return new Attendee(items[0], MainWindow.EventsList.Find(x => x.name == items[1]), ReadTimes(items[2].Split(',')));
        }

        /// <summary>
        /// Reads the event from a string array
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns></returns>
        internal static Event ReadEvent(string[] items)
        {
            if (items.Length != 4)
                return null;
            return new Event(items[0], items[1], DateTime.Parse(items[2]), ReadTimes(items[3].Split(',')));
        }
    }
}