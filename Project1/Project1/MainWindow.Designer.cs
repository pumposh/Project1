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
            this.SuspendLayout();
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(1098, 16);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(201, 52);
            this.addEventButton.TabIndex = 1;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // availabilityButton
            // 
            this.availabilityButton.Location = new System.Drawing.Point(1098, 87);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(201, 65);
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
            this.columnHeader11});
            this.attendeeView.GridLines = true;
            this.attendeeView.Location = new System.Drawing.Point(12, 264);
            this.attendeeView.Name = "attendeeView";
            this.attendeeView.Size = new System.Drawing.Size(1287, 341);
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
            this.columnHeader11.Width = 1000;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1098, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "24 hour mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.eventView.AllowDrop = true;
            this.eventView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13});
            this.eventView.FullRowSelect = true;
            this.eventView.GridLines = true;
            this.eventView.Location = new System.Drawing.Point(15, 16);
            this.eventView.Name = "listView1";
            this.eventView.Size = new System.Drawing.Size(1077, 209);
            this.eventView.TabIndex = 6;
            this.eventView.UseCompatibleStateImageBehavior = false;
            this.eventView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Event Name";
            this.columnHeader5.Width = 113;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Event Host";
            this.columnHeader6.Width = 98;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Event Date";
            this.columnHeader10.Width = 94;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Attendee Count";
            this.columnHeader12.Width = 110;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Event Times";
            this.columnHeader13.Width = 1000;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 652);
            this.Controls.Add(this.eventView);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.attendeeView);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.addEventButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
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
    }
}

