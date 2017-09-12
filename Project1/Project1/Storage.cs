using System;
using System.IO;
using System.Windows.Forms;

namespace Project1
{
    internal class Storage
    {
        /// <summary>
        /// Output Format: user_name, event_name, event_time, [times available]
        /// </summary>
        /// <param name="user_name">user name</param>
        /// <param name="event_name">event name</param>
        /// <param name="eventTime">The event time.</param>
        internal static void AddEvent(string user_name, string event_name, String eventTime, ListBox.ObjectCollection available_times)
        {
            //Write a value to the specified path
            try
            {
                //Create IO stream
                FileStream iOflow = new FileStream(Environment.CurrentDirectory + "\\record.txt", FileMode.Append);
                //Create a writer
                StreamWriter writer = new StreamWriter(iOflow);
                //Writes the specified content to the file
                writer.WriteLine("nameBox:" + user_name + "\teventNameBox:" + event_name + "\teventTime:" + eventTime);
                //Close the writer
                writer.Close();
                //Close the file stream
                iOflow.Close();
            }
            catch (Exception)
            {
            }

        }


        /// <summary>
        /// Format: user_name, event_name, [times available]
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="event_name">Name of the event.</param>
        /// <param name="available_times">The available times.</param>
        internal static void AddAttendee(string name, string event_name, ListBox.ObjectCollection available_times)
        {

        }

        /// <summary>
        /// Put events into a list from a file.
        /// </summary>
        internal static void ReadEvents()
        {

        }
    }
}