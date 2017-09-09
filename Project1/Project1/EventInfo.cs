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
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            //TODO:: if no item is selected in listbox then prompt for a selection
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            //TODO:: save information into a file
        }
    }
}
