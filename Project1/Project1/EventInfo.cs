using System;
using System.Windows.Forms;
using System.Linq;

namespace Project1
{
    public partial class EventInfo : Form
    {
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (timeBox.SelectedItem == null)
            {
                MessageBox.Show("Select a valid time slot.");
                return;
            }
            if (listBox1.Items.Contains(timeBox.SelectedItem))
            {
                MessageBox.Show("The selected time slot has already been added.");
                return;
            }

            if (listBox1.Items.Count == 0)
                listBox1.Items.Add(timeBox.SelectedItem);
            else
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (DateTime.Parse(listBox1.Items[i].ToString()) > DateTime.Parse(timeBox.SelectedItem.ToString()))
                    {
                        listBox1.Items.Insert(i, timeBox.SelectedItem);
                        break;
                    }
                    if (i == listBox1.Items.Count - 1) //if it's the maximum element then add to the end
                    {
                        listBox1.Items.Add(timeBox.SelectedItem);
                        break;
                    }
                }
        }

        /// <summary>
        /// Removes the selected item from listbox1 if an item is selected.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a time slot to remove from the listbox.");
                return;
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        /// <summary>
        /// Saves event information to a file and checks for correctness.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Enter your event times.");
                return;
            }

            Storage.AddEvent(nameBox.Text, eventNameBox.Text, eventTime.ToString("hh:mm tt"), listBox1.Items);
           // main.AddEvent()
        }

        /// <summary>
        /// Adds time slots into combobox for selection in 12 hr format and prevents user from picking an earlier date than today.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EventInfo_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            DateTime time = DateTime.Parse("00:00");
            for (int i = 0; i < 48; i++)
            {
                timeBox.Items.Add(time.ToString("hh:mm tt"));
                time = time.AddMinutes(30);
            }
        }

        /// <summary>
        /// Changes time format between 24 hr and 12 hr format for combobox and listbox.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timeBox.Items.Clear();
            timeBox.Text = "";
            DateTime time = DateTime.Parse("00:00");
            for (int i = 0; i < 48; i++)
            {
                if (checkBox1.Checked)
                    timeBox.Items.Add(time.ToString("HH:mm"));
                else
                    timeBox.Items.Add(time.ToString("hh:mm tt"));
                time = time.AddMinutes(30);
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (checkBox1.Checked)
                    listBox1.Items[i] = DateTime.Parse(listBox1.Items[i].ToString()).ToString("HH:mm");
                else
                    listBox1.Items[i] = DateTime.Parse(listBox1.Items[i].ToString()).ToString("hh:mm tt");
            }
        }
	
	
    }
}
