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

        private void removeButton_Click(object sender, EventArgs e)
        {
            //TODO:: if no item is selected in listbox then prompt for a selection
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            //TODO:: save information into a file
        }

        /// <summary>
        /// Adds time slots into combobox for selection in 12 hr format.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EventInfo_Load(object sender, EventArgs e)
        {
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
