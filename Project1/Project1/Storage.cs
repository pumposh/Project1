using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Project1
{
    /// <summary>
    /// Class for helping with file storage/reading
    /// </summary>
    internal class Storage
    {
        /// <summary>
        /// Formats a DateTime array into a string
        /// </summary>
        /// <param name="times">The times.</param>
        /// <param name="mode24">if set to <c>true</c> [mode24].</param>
        /// <returns></returns>
        internal static String DateTimesFormatted(DateTime[] times, bool mode24 = false)
        {
            string builder = string.Empty;
            if (times.Length == 0)
                return builder;

            for(int i = 0; i < times.Length - 1; i++)
            {
                if(mode24)
                    builder += times[i].ToString("MM/dd/yyyy-HH:mm") + ",";
                else
                    builder += times[i].ToString("MM/dd/yyyy-hh:mm-tt") + ",";
            }
            if (mode24)
                builder += times[times.Length - 1].ToString("MM/dd/yyyy-HH:mm");
            else
                builder += times[times.Length - 1].ToString("MM/dd/yyyy-hh:mm-tt");
            return builder;
        }

        internal static String datesFormatted(DateTime[] times)
        {
            string builder = string.Empty;
            if (times.Length == 0)
                return builder;
            string[] dates = new string[times.Length];

            for (int i = 0; i < times.Length - 1; i++)
            {
                if (dates[i] != times[i].ToString("MM/dd/yyyy"))
                {
                    builder += times[i].ToString("MM/dd/yyyy") + ", ";
                    dates[i] = times[i].ToString("MM/dd/yyyy");
                }
            }

            builder += times[times.Length - 1].ToString("MM/dd/yyyy");
            return builder;

        }
		/// <summary>
		/// Formats a task list into a string
		/// </summary>
		/// <param name="tasks">The tasks.</param>
		/// <returns></returns>
		internal static String TaskListFormatted(List<String> tasks)
        {
            String builder = String.Empty;

            if (tasks.Count == 0)
                return ",";

            for (int i = 0; i < tasks.Count-1; i++)
            {
                builder += tasks[i] + ",";
            }

            return builder;
        }

        /// <summary>
        /// Reads the times.
        /// </summary>
        /// <param name="times">The times.</param>
        /// <returns></returns>
        private static DateTime[] ReadDateTimes(string[] times)
        {
            if (times.Length == 0)
                return new DateTime[0];
            DateTime[] dTimes = new DateTime[times.Length];

            for(int i = 0; i < times.Length; i++)
            {
                try
                {
                    dTimes[i] = DateTime.ParseExact(times[i], "MM/dd/yyyy-hh:mm-tt", CultureInfo.InvariantCulture);
                }
                catch
                {

                }
            }
            return dTimes;
        }

		/// <summary>
		/// Reads the tasks.
		/// </summary>
		/// <param name="tasks">The tasks.</param>
		/// <returns></returns>
		private static List<String> ReadTasks(string[] tasks)
		{
			if (tasks.Length == 0)
				return new List<string>();
            List<string> taskList = new List<String>();

			for (int i = 0; i < tasks.Length; i++)
			{
                taskList.Add(tasks[i]);
			}
			return taskList;
		}

        /// <summary>
        /// Adds Event to file.
        /// Output Format: user_name    event_name  [times available]   separated by a ,
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
            writer.WriteLine(ev.host + "\t" + ev.name + "\t" + DateTimesFormatted(ev.dateTimes) + "\t" + TaskListFormatted(ev.taskList));
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
            writer.WriteLine(attendee.name + "\t" + attendee.ev.name + "\t" + DateTimesFormatted(attendee.availableTimes) + "\t" + TaskListFormatted(attendee.attendeeTasks));
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
            if (items.Length != 4)
                return null;
            
            Attendee attendee = new Attendee(items[0], MainWindow.EventsList.Find(x => x.name == items[1]), ReadDateTimes(items[2].Split(',')), ReadTasks(items[3].Split(',')));
            return attendee;
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
            return new Event(items[0], items[1], ReadDateTimes(items[2].Split(',')), ReadTasks(items[3].Split(',')));
        }
    }
}
