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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!File.Exists(Application.StartupPath + "\\record.txt"))
            {
                File.Create(Application.StartupPath + "\\record.txt");
            }
            if (!File.Exists(Application.StartupPath + "\\recordattendee.txt"))
            {
                File.Create(Application.StartupPath + "\\recordattendee.txt");
            }
            //push event info to listView1
            listView1.Items.Clear();
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
                event1.Eventcreator  = vitems[0];
                event1.Eventname = vitems[1];
                event1.Event_date = vitems[2];
                event1.Event_starttime  = vitems[3];
                event1.Event_endtime = vitems[4];
                list_event.Add(event1);

            }
            sr.Close();

            if (list_event.Count > 0)
            {
                foreach (event_description e in list_event)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = e.Eventcreator ;
                    item.SubItems.AddRange(new string[] { e.Eventname , e.Event_date ,e.Event_starttime, e.Event_endtime, });
                    listView1.Items.Add(item);
                }
            }
            //push attendee to listview2
            listView2.Items.Clear();
            StreamReader sr2 = new StreamReader(Application.StartupPath + "\\recordattendee.txt");
            string vline2;



            while ((vline2 = sr2.ReadLine()) != null)
            {


                string[] vitems2 = vline2.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (vitems2.Length <= 0)
                {
                    continue;
                }
                Attendee attendee = new Attendee();
                attendee.Attendee_name = vitems2[0];
                attendee.Event_name = vitems2[1];
                attendee.Available_time = vitems2[2];
                list_attendee.Add(attendee);

            }
            sr2.Close();

            if (list_attendee.Count > 0)
            {
                foreach (Attendee f in list_attendee)
                {
                    ListViewItem item2 = new ListViewItem();
                    item2.Text = f.Attendee_name;
                    item2.SubItems.AddRange(new string[] { f.Event_name , f.Available_time  });
                    listView2.Items.Add(item2);
                }
            }

            
            

        }
        List<event_description> list_event = new List<event_description>();
        List<Attendee> list_attendee = new List<Attendee>();

        /// <summary>
        /// Ask for event infromation in a new window and updates listbox for available events.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void availabilityButton_Click(object sender, EventArgs e)
        {
            AvailabilityForm availabilityForm = new AvailabilityForm();
            availabilityForm.Show();
        }
        //refresh eventlist
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            list_event.Clear();

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
                event1.Eventname = vitems[0];
                event1.Eventcreator = vitems[1];
                event1.Event_date = vitems[2];
                event1.Event_starttime = vitems[3];
                event1.Event_endtime = vitems[4];
                list_event.Add(event1);

            }
            sr.Close();

            if (list_event.Count > 0)
            {
                foreach (event_description event2 in list_event)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = event2.Eventname;
                    item.SubItems.AddRange(new string[] { event2.Eventcreator, event2.Event_date, event2.Event_starttime, event2.Event_endtime, });
                    listView1.Items.Add(item);
                }
            }
        }
        //refresh attendee
        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            list_attendee.Clear();
            StreamReader sr2 = new StreamReader(Application.StartupPath + "\\recordattendee.txt");
            string vline2;



            while ((vline2 = sr2.ReadLine()) != null)
            {


                string[] vitems2 = vline2.Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (vitems2.Length <= 0)
                {
                    continue;
                }
                Attendee attendee = new Attendee();
                attendee.Attendee_name = vitems2[0];
                attendee.Event_name = vitems2[1];
                attendee.Available_time = vitems2[2];
                list_attendee.Add(attendee);

            }
            sr2.Close();

            if (list_attendee.Count > 0)
            {
                foreach (Attendee f in list_attendee)
                {
                    ListViewItem item2 = new ListViewItem();
                    item2.Text = f.Attendee_name;
                    item2.SubItems.AddRange(new string[] { f.Event_name, f.Available_time });
                    listView2.Items.Add(item2);
                }
            }
        }

     
    }
}
