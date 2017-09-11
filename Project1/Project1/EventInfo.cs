using System;
using System.Windows.Forms;
using System.Linq;

namespace Project1
{
    public partial class EventInfo : Form
    {
        //TODO:: fill timeBox (a comboBox) with 30 minute intervals of time 
        public EventInfo()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //TODO:: add a valid timeBox item to listbox
            if (timeBox.SelectedItem == null)
                return;
            if (listBox1.Items.Contains(timeBox.SelectedItem))
                return;
            listBox1.Items.Add(timeBox.SelectedItem);
            SortListBox();
        }

        private void SortListBox()
        {
		int listBoxLength = listBox1.Items.Count;
		DateTime[] time = new DateTime[listBoxLength - 1];//Array to hold new ordered dateTimes

		//Copies items in listBox1 to an array
		for(int i=0;i<listBoxLength - 1;i++)
		{
			time[i] = (DateTime)listBox1.Items[i];
		}
		
		listBox1.Items.Clear();//clears listbox after all items have been copied

		DateTime swapHolder = time[0];//holds a DateTime for swapping so no data is lost
		int k = 0;//holds position of lowest DateTime that has not been sorted

		//Sorts items in array
		for(int i=0;i<listBoxLength - 1;i++)
		{
			//currentLowest = time[i];
			for(int j=i;j<listBoxLength - 1;j++)
			{
				if(time[j].Hour < time[k].Minute)
				{
					if(time[j].Minute < time[k].Minute)
					{
						k = j;
						//currentLowest = time[j];
					}
				}
			}
			swapHolder = time[i];
			time[i] = time[k];
			time[k] = swapHolder;
		}
		
		//puts new sorted times in listbox
		for(int i = 0;i<listBoxLength;i++)
		{
			listBox1.Items.Add(time[i]);
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
                return;
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
            Storage.AddEvent(nameBox.Text, eventNameBox.Text, eventTime, listBox1.Items);
            //TODO:: save information into a file
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
            //TODO:: change combobox and listbox format
            timeBox.Items.Clear();
            timeBox.Text = "";
            DateTime time = DateTime.Parse("00:00");
            if (checkBox1.Checked)
            {
                for (int i = 0; i < 48; i++)
                {
                    timeBox.Items.Add(time.ToString("HH:mm"));
                    time = time.AddMinutes(30);
                }
            }
            else
            {
                for (int i = 0; i < 48; i++)
                {
                    timeBox.Items.Add(time.ToString("hh:mm tt"));
                    time = time.AddMinutes(30);
                }
            }
        }
	
	
    }
}
