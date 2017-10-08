using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    /// The Main Window form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainWindow : Form
    {
        /// <summary>
        /// The events list
        /// </summary>
        internal static List<Event> EventsList = new List<Event>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ask for event infromation in a new window and updates listbox for available events.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addEventButton_Click(object sender, EventArgs e)
        {
            EventInfo eventInfo = new EventInfo(this);
            eventInfo.Show();
            
        }
        /// <summary>
        /// If no listBox item is selected, prompt the user for a listbox selection.
        /// From that listbox selection, prompt the user for available dates for the selected event in a new window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void availabilityButton_Click(object sender, EventArgs e)
        {
            AvailabilityForm availabilityForm = new AvailabilityForm(this);
            availabilityForm.Show();
        }

        /// <summary>
        /// Handles the Load event of the MainWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(Application.StartupPath + "\\record.txt", FileMode.OpenOrCreate))
            using (StreamReader sr = new StreamReader(fs))
            {
                string vline;
                while ((vline = sr.ReadLine()) != null)
                {
                    string[] vitems = vline.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (vitems.Length <= 0)
                    {
                        continue;
                    }
                    EventsList.Add(Storage.ReadEvent(vitems));
                }
            }
            //push attendee to listview2
            using (FileStream fs = new FileStream(Application.StartupPath + "\\recordattendee.txt", FileMode.OpenOrCreate))
            using (StreamReader sr2 = new StreamReader(fs))
            {
                string vline2;

                while ((vline2 = sr2.ReadLine()) != null)
                {
                    string[] vitems2 = vline2.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (vitems2.Length <= 0)
                    {
                        continue;
                    }
                    Attendee attendee = Storage.ReadAttendee(vitems2);
                    EventsList.Find(x => x.ToString() == attendee.ev.ToString()).attendees.Add(attendee);
                }
            }
            ReloadEvents();
            ReloadAttendees();
        }

        /// <summary>
        /// Reloads the attendees.
        /// </summary>
        internal void ReloadAttendees()
        {
            attendeeView.Items.Clear();
            foreach (Event ev in EventsList)
                foreach (Attendee f in ev.attendees)
                {
                    ListViewItem item2 = new ListViewItem();
                    item2.Text = f.ev.name;
                    item2.SubItems.AddRange(new string[] { f.name, Storage.DateTimesFormatted(f.availableTimes, checkBox1.Checked) });
                    attendeeView.Items.Add(item2);
                }
        }

        /// <summary>
        /// Reloads the events.
        /// </summary>
        internal void ReloadEvents()
        {
            eventView.Items.Clear();
            if (EventsList.Count > 0)
            {
                foreach (Event ev in EventsList)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ev.name;
                    item.SubItems.AddRange(new string[] { ev.host, ev.attendees.Count.ToString(), Storage.DateTimesFormatted(ev.dateTimes, checkBox1.Checked) });
                    eventView.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the checkBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ReloadEvents();
            ReloadAttendees();
        }
    }
}
