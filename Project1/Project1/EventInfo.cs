using System;
using System.Windows.Forms;
using System.Linq;

namespace Project1
{
    public partial class EventInfo : Form
    {
        public EventInfo(Form f)
        {
            InitializeComponent();
        }
        //add the starttime
        private void addButton_Click(object sender, EventArgs e)
        {
            if (timeBox.SelectedItem == null)
            {
                MessageBox.Show("Select a valid time slot.");
                return;
            }
            if (listBox1.Items.Count>=1)
            {
                MessageBox.Show("You have added the start time ");
                return;
            }
            listBox1.Items.Add(timeBox.SelectedItem);
        }
        //add the endtime
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items == null)
            {
                MessageBox.Show("please add the start time at first");
                return;
 
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a valid time slot.");
                return;
            }

            if (listBox1.Items.Count >= 2)
            {
                MessageBox.Show("You have added the end time ");
                return;
            }
            DateTime[] time = new DateTime[2];
            time[0] = DateTime.Parse(timeBox.SelectedItem.ToString());
            time[1] = DateTime.Parse(comboBox1.SelectedItem.ToString());

            if (time[0] >=time[1])
            {
                MessageBox.Show("Endtime must be later than Starttime");
                return;
            }
            listBox1.Items.Add(comboBox1.SelectedItem);
        }

        private void SortListBox()
        {
            int listBoxLength = listBox1.Items.Count;
            DateTime[] time = new DateTime[listBoxLength];//Array to hold new ordered dateTimes

            //Copies items in listBox1 to an array
            for (int i = 0; i < listBoxLength; i++)
            {
                time[i] = DateTime.Parse(listBox1.Items[i].ToString());
            }

            listBox1.Items.Clear();//clears listbox after all items have been copied

            DateTime swapHolder = time[0];//holds a DateTime for swapping so no data is lost
            int k = 0;//holds position of lowest DateTime that has not been sorted

            //Sorts items in array
            for (int i = 0; i < listBoxLength; i++)
            {
                for (int j = i; j < listBoxLength; j++)
                {
                    if (time[j] < time[k])
                    {
                            k = j;
                    }
                }
                swapHolder = time[i];
                time[i] = time[k];
                time[k] = swapHolder;
            }

            //puts new sorted times in listbox
            for (int i = 0; i < listBoxLength; i++)
            {
                if (checkBox1.Checked)
                    listBox1.Items.Add(time[i].ToString("HH:mm"));
                else
                    listBox1.Items.Add(time[i].ToString("hh:mm tt"));
            }
        }

        /// <summary>
        /// Removes the selected item from listbox1 if an item is selected.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void removeButton_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
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
            String a = Convert.ToString(eventTime);
            Storage.AddEvent(nameBox.Text, eventNameBox.Text, a, timeBox.SelectedItem .ToString (), comboBox1.SelectedItem.ToString());
            Storage.AddAttendee(nameBox.Text, eventNameBox.Text, timeBox.SelectedItem.ToString() + "-to-" + comboBox1.SelectedItem.ToString());
            MessageBox.Show("successfully added");

            
            //TODO:: save information into a file
            // flush the gridlist
         
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
                comboBox1.Items.Add(time.ToString("hh:mm tt"));
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
            //TODO:: change combobox and listbox format
            timeBox.Items.Clear();
            comboBox1.Items.Clear();
            timeBox.Text = "";
            comboBox1.Text = "";
            DateTime time = DateTime.Parse("00:00");
            for (int i = 0; i < 48; i++)
            {
                if (checkBox1.Checked)
                {
                    timeBox.Items.Add(time.ToString("HH:mm"));
                    comboBox1.Items.Add(time.ToString("HH:mm"));
                }
                else
                {
                    timeBox.Items.Add(time.ToString("hh:mm tt"));
                    comboBox1.Items.Add(time.ToString("hh:mm tt"));
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


	
	
    }
}
