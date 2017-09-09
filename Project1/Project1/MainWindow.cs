using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }


        /// <summary>
        /// Ask for event infromation in a new window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addEventButton_Click(object sender, EventArgs e)
        {
            EventInfo eventInfo = new EventInfo();
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
            
        }
    }
}
