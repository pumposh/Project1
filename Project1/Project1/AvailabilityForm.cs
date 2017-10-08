using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Project1
{
	public partial class AvailabilityForm : Form
	{
		/// <summary>
		/// The main
		/// </summary>
		MainWindow main;

		/// <summary>
		/// Initializes a new instance of the <see cref="AvailabilityForm" /> class.
		/// </summary>
		/// <param name="m">The m.</param>
		public AvailabilityForm(MainWindow m)
		{
			InitializeComponent();
			main = m;
		}

		/// <summary>
		/// Handles the 1 event of the AvailabilityForm_Load control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void AvailabilityForm_Load_1(object sender, EventArgs e)
		{
			MainWindow.EventsList.ForEach((Event ev) =>
			{
				eventsBox.Items.Add(ev);
			});
		}

		/// <summary>
		/// Handles the CheckedChanged event of the checkBox1 control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < timesBox.Items.Count; i++)
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

		/// <summary>
		/// Handles the Click event of the addButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void addButton_Click(object sender, EventArgs e)
		{
			if (timesBox.SelectedItem == null)
			{
				MessageBox.Show("Select an available time.");
				return;
			}
			if (listBox1.Items.Contains(timesBox.SelectedItem))
			{
				MessageBox.Show("The selected time has already been added.");
				return;
			}

			listBox1.Items.Add(timesBox.SelectedItem);
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the eventsBox control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void eventsBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (eventsBox.SelectedItem == null)
				return;
			timesBox.Items.Clear();
			Event ev = eventsBox.SelectedItem as Event;
			for (int i = 0; i < ev.dateTimes.Length; i++)
			{
                timesBox.Items.Add(ev.dateTimes[i].ToString("MM/dd/yyyy hh:mm tt"));
			}
		}

		/// <summary>
		/// Handles the Click event of the attendeeButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void attendeeButton_Click(object sender, EventArgs e)
		{
			if (nameBox.Text == string.Empty)
			{
				MessageBox.Show("Enter your name.");
				return;
			}
			if (eventsBox.SelectedItem == null)
			{
				MessageBox.Show("Select an event to attend.");
				return;
			}
			if (listBox1.Items.Count == 0)
			{
				MessageBox.Show("Give some available times.");
				return;
			}

			Event ev = MainWindow.EventsList.Find(x => x.ToString() == (eventsBox.SelectedItem as Event).ToString());
			Attendee attendee = new Attendee(nameBox.Text, ev, TimeSlots(), attendeeTask_List);
			if (ev.attendees.Find(x => x.name == attendee.name) != null)
			{
				MessageBox.Show(attendee.name + " is already attending event " + ev.name + ".");
				return;
			}
			MainWindow.EventsList.Find(x => x == ev).attendees.Add(attendee);
			Storage.AddAttendee(attendee);
			main.ReloadAttendees();
			main.ReloadEvents();
			MessageBox.Show("Attendee information has been added.");
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
		/// Handles the Click event of the clearButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void clearButton_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}

		private void tasksList_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// Handles the Click event of the clearTask control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void clearTasks_Click(object sender, EventArgs e)
		{
			tasksList.Items.Clear();
		}

		/// <summary>
		/// Handles the Click event of the addTask control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void addTask_Click(object sender, EventArgs e)
		{
			if (selectTask.SelectedItem == null)
			{
				MessageBox.Show("Select an available Task.");
				return;
			}

			if (tasksList.Items.Contains(selectTask.SelectedItem))
			{
				MessageBox.Show("The selected Task has already been added.");
				return;
			}

			tasksList.Items.Add(selectTask.SelectedItem);
			attendeeTask_List.Add(selectTask.SelectedItem.ToString());
		}

		/// <summary>
		/// Handles the SelectedIndexChanged event of the selectTask control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
		private void selectTask_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (selectTask.SelectedItem == null)
				return;
			selectTask.Items.Clear();
			Event ev = selectTask.SelectedItem as Event;
			for (int i = 0; i < ev.taskList.Count; i++)
			{
				selectTask.Items.Add(ev.taskList[i]); //fills out the select task combo box with itmes from the events task list
			}
		}

		private List<String> attendeeTask_List = new List<string>(); //list to keep track of the tasks an attendee signs up for

	}
}
