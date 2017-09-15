using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class AvailabilityForm : Form
    {
        public AvailabilityForm()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader(Application.StartupPath + "\\record.txt");
            string vline;



            while ((vline = sr.ReadLine()) != null)
            {


                string[] vitems = vline.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (vitems.Length <= 0)
                {
                    continue;
                }

                event_description event1 = new event_description();
                event1.Eventcreator   = vitems[0];
                event1.Eventname  = vitems[1];
                event1.Event_date = vitems[2];
                event1.Event_starttime = vitems[3];
                event1.Event_endtime = vitems[4];
                list_event.Add(event1);

            }
            sr.Close();
            foreach (event_description event1 in list_event)
            {
                comboBox1.Items.Add(event1.Eventname);

               
            }



        }
        List<event_description> list_event = new List<event_description>();

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// recordattendee.txt
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Enter the attendee name.");
                return;
            }
            if (comboBox1.SelectedItem  == string.Empty)
            {
                MessageBox.Show("select an event name.");
                return;
            }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Enter your available times.");
                return;
            }
            string available_times="";


           foreach (string a in listBox1.Items)
            {
                available_times = available_times+ "&&"+a ;
            }
           Storage.AddAttendee(textBox1.Text, comboBox1.SelectedItem.ToString(), available_times);
            MessageBox.Show("successfully added");
        }
        private void AvailabilityForm_Load(object sender, EventArgs e)
        {
            
            foreach (event_description event1 in list_event)
            {
                comboBox1.Items.Add(event1.Eventname);
                //comboBox1.Items.Add(event1.Event_starttime);
                //time = time.AddMinutes(30);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeBox.Items.Clear();
            foreach (event_description event1 in list_event)
            {
                if (comboBox1.SelectedItem== event1.Eventname)
                {
                    DateTime time = Convert.ToDateTime(event1.Event_starttime);
                    DateTime time1 = Convert.ToDateTime(event1.Event_endtime);
                    DateTime time2;
                    while(time<time1)
                    {
                        time2 = time.AddMinutes(30);
                        timeBox.Items.Add(time.ToString("hh:mm tt") +"  to  "+ time2.ToString("hh:mm tt"));
                        time = time.AddMinutes(30);
                    }
                    
                    
                }
                


            }
        }

        //function for switch betwwen 12 hrs and 24 hrs
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //TODO:: change combobox and listbox format
            timeBox.Items.Clear();
            foreach (event_description event1 in list_event)
            {
                if (comboBox1.SelectedItem == event1.Eventname)
                {
                    DateTime time = Convert.ToDateTime(event1.Event_starttime);
                    DateTime time1 = Convert.ToDateTime(event1.Event_endtime);
                    DateTime time2;
                    while (time < time1)
                    {
                            time2 = time.AddMinutes(30);
                           if (checkBox1.Checked)
                           {
                               timeBox.Items.Add(time.ToString("HH:mm") + "  to  " + time2.ToString("HH:mm"));
                           }
                           else

                           {
                               timeBox.Items.Add(time.ToString("hh:mm tt") + "  to  " + time2.ToString("hh:mm tt"));
                           }
                           time = time.AddMinutes(30);
                    }
                }
            }
            //switch in listbox 
            for (int i = 0; i < listBox1.Items.Count; i++)
            {

                if (checkBox1.Checked)
                {
                    string[] vitems = listBox1.Items[i].ToString().Split(new string[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
                    DateTime time3 = Convert.ToDateTime(vitems[0]);
                    DateTime time4 = Convert.ToDateTime(vitems[1]);
                    listBox1.Items[i] = time3.ToString("HH:mm") +"  to   " +time4.ToString("HH:mm");
                }
                else
                {
                    string[] vitems = listBox1.Items[i].ToString().Split(new string[] { "to" }, StringSplitOptions.RemoveEmptyEntries);
                    DateTime time3 = Convert.ToDateTime(vitems[0]);
                    DateTime time4 = Convert.ToDateTime(vitems[1]);
                    listBox1.Items[i] = time3.ToString("hh:mm tt") + "  to   " + time4.ToString("hh:mm tt");
                  
                }
            }
        }
        //add availablity attendee
        private void addButton_Click(object sender, EventArgs e)
        {
            if (timeBox.SelectedItem == null)
            {
                MessageBox.Show("Select a valid time slot.");
                return;
            }
            if (listBox1 .Items .Contains(timeBox.SelectedItem ))
            {
                MessageBox.Show("The selected time slot has already been added ");
                return;
            }
            listBox1.Items.Add(timeBox.SelectedItem);
        }

    }
}
