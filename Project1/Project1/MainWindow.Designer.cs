namespace Project1
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addEventButton = new System.Windows.Forms.Button();
            this.availabilityButton = new System.Windows.Forms.Button();
            this.attendeeView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.eventView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(1235, 20);
            this.addEventButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(226, 65);
            this.addEventButton.TabIndex = 1;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // availabilityButton
            // 
            this.availabilityButton.Location = new System.Drawing.Point(1235, 109);
            this.availabilityButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(226, 81);
            this.availabilityButton.TabIndex = 2;
            this.availabilityButton.Text = "Add Availability";
            this.availabilityButton.UseVisualStyleBackColor = true;
            this.availabilityButton.Click += new System.EventHandler(this.availabilityButton_Click);
            // 
            // attendeeView
            // 
            this.attendeeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader2});
            this.attendeeView.GridLines = true;
            this.attendeeView.Location = new System.Drawing.Point(14, 330);
            this.attendeeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attendeeView.Name = "attendeeView";
            this.attendeeView.Size = new System.Drawing.Size(1447, 425);
            this.attendeeView.TabIndex = 4;
            this.attendeeView.UseCompatibleStateImageBehavior = false;
            this.attendeeView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Event Name";
            this.columnHeader3.Width = 134;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Attendee";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Available Time";
            this.columnHeader11.Width = 125;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1235, 255);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "24 hour mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // eventView
            // 
            this.eventView.AllowDrop = true;
            this.eventView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader5,
            this.columnHeader1});
            this.eventView.FullRowSelect = true;
            this.eventView.GridLines = true;
            this.eventView.Location = new System.Drawing.Point(15, 20);
            this.eventView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventView.Name = "eventView";
            this.eventView.Size = new System.Drawing.Size(1211, 260);
            this.eventView.TabIndex = 6;
            this.eventView.UseCompatibleStateImageBehavior = false;
            this.eventView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 0;
            this.columnHeader5.Text = "Event Name";
            this.columnHeader5.Width = 113;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 1;
            this.columnHeader6.Text = "Event Host";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 2;
            this.columnHeader10.Text = "Event Date";
            this.columnHeader10.Width = 94;
            // 
            // columnHeader12
            // 
            this.columnHeader12.DisplayIndex = 3;
            this.columnHeader12.Text = "Attendee Count";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.DisplayIndex = 4;
            this.columnHeader13.Text = "Event Times";
            this.columnHeader13.Width = 113;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Task List";
            this.columnHeader1.Width = 1000;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tasks";
            this.columnHeader2.Width = 1000;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 815);
            this.Controls.Add(this.eventView);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.attendeeView);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.addEventButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button availabilityButton;
        private System.Windows.Forms.ListView attendeeView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView eventView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

