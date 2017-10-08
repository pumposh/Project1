using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project1
{
    /// <summary>
    /// The event creation form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EventInfo : Form
    {
        /// <summary>
        /// The main
        /// </summary>
        internal MainWindow main = null;

        /// <summary>
        /// Passes the MainWindow into this window to allow interaction between the two.
        /// </summary>
        /// <param name="m">The MainWindow.</param>
        public EventInfo(MainWindow m)
        {
            InitializeComponent();
            main = m;
        }

        /// <summary>
        /// Adds a selected time from the timeBox to the listBox. The Item is inserted in ascending order.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (timesBox.SelectedItem == null)
            {
                MessageBox.Show("Select a valid time slot.");
                return;
            }
            if (listBox1.Items.Contains(timesBox.SelectedItem))
            {
                MessageBox.Show("The selected time has already been added.");
                return;
            }

            if (listBox1.Items.Count == 0)
                listBox1.Items.Add(timesBox.SelectedItem);
            else
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (DateTime.Parse(listBox1.Items[i].ToString()) > DateTime.Parse(timesBox.SelectedItem.ToString()))
                    {
                        listBox1.Items.Insert(i, timesBox.SelectedItem);
                        break;
                    }
                    if (i == listBox1.Items.Count - 1) //if it's the maximum element then add to the end
                    {
                        listBox1.Items.Add(timesBox.SelectedItem);
                        break;
                    }
                }

        }

        /// <summary>
        /// Deletes all time slots from the listbox
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        /// <summary>
        /// Saves event information to a file and checks for correctness.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addEventButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == String.Empty)
            {
                MessageBox.Show("Enter the user name.");
                return;
            }
            if (eventNameBox.Text == string.Empty)
            {
                MessageBox.Show("Enter an event name.");
                return;
            }
            DateTime eventTime;
            if (!DateTime.TryParse(dateTimePicker1.Text, out eventTime))
            {
                MessageBox.Show("Invalid date for the event chosen.");
                return;
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Enter your event times.");
                return;
            }

            Event ev = new Event(nameBox.Text, eventNameBox.Text, TimeSlots(), task_List);
            if (MainWindow.EventsList.Find(x => x.ToString() == ev.ToString()) != null)
            {
                MessageBox.Show("This event has already been scheduled.");
                return;
            }
            Storage.AddEvent(ev);
            MainWindow.EventsList.Add(ev);
            main.ReloadEvents();
            MessageBox.Show("Successfully added the event.");
        }

        /// <summary>
        /// Times the slots.
        /// </summary>
        /// <returns></returns>
        private DateTime[] TimeSlots()
        {
            DateTime[] times = new DateTime[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                times[i] = DateTime.Parse(listBox1.Items[i].ToString());
            }
            return times;
        }

        /// <summary>
        /// Adds time slots into combobox for selection in 12 hr format and prevents user from picking an earlier date than today.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void EventInfo_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            DateTime time = DateTime.Parse("00:00");
            for (int i = 0; i < 48; i++)
            {
                timesBox.Items.Add(time.ToString("hh:mm tt"));
                time = time.AddMinutes(30);
            }
        }

        /// <summary>
        /// Changes time format between 24 hr and 12 hr format for combobox and listbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 48; i++)
            {
                if (checkBox1.Checked)
                    timesBox.Items[i] = DateTime.Parse(timesBox.Items[i].ToString()).ToString("HH:mm");
                else
                    timesBox.Items[i] = DateTime.Parse(timesBox.Items[i].ToString()).ToString("hh:mm tt");
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (checkBox1.Checked)
                    listBox1.Items[i] = DateTime.Parse(listBox1.Items[i].ToString()).ToString("HH:mm");
                else
                    listBox1.Items[i] = DateTime.Parse(listBox1.Items[i].ToString()).ToString("hh:mm tt");
            }
        }

        private void taskBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void taskBox_TextChanged(object sender, EventArgs e)
        {

        }
        private List<String> task_List = new List<string>(); //list to keep track of the strings entered into the task box


        /// <summary>
        /// Adds string from the taskBox to the taskListBox
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void addTaskButton_Click(object sender, EventArgs e)
        {
            if (taskBox.Text == String.Empty)
            {
                MessageBox.Show("Enter a task.");
                return;
            }
            if (taskListBox.Items.Contains(taskBox.Text))
            {
                MessageBox.Show("The task has already been added.");
                return;
            }
            else
            {
                taskListBox.Items.Add(taskBox.Text); //adds string from taskBox to the taskListBox
                task_List.Add(taskBox.Text); //adds string to a Last of strings that will keep track of the task List for the event.
            }
            }

        /// <summary>
        /// Deletes all tasks listed in the taskListBox
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void clearTaskList_Click(object sender, EventArgs e)
        {
            taskListBox.Items.Clear();
        }
    }
}