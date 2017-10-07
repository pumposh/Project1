namespace Project1
{
    /// <summary>
    /// Designer for event form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class EventInfo
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
            this.eventNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timesBox = new System.Windows.Forms.ComboBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.taskBox = new System.Windows.Forms.TextBox();
            this.clearTaskList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventNameBox
            // 
            this.eventNameBox.Location = new System.Drawing.Point(120, 44);
            this.eventNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eventNameBox.Name = "eventNameBox";
            this.eventNameBox.Size = new System.Drawing.Size(206, 26);
            this.eventNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event Name:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 76);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(148, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours Available:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(17, 155);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 84);
            this.listBox1.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(187, 284);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(141, 30);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add time slot";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(86, 248);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(183, 30);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Clear Times";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(176, 115);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "24 hour mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timesBox
            // 
            this.timesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timesBox.FormattingEnabled = true;
            this.timesBox.Location = new System.Drawing.Point(17, 285);
            this.timesBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timesBox.Name = "timesBox";
            this.timesBox.Size = new System.Drawing.Size(163, 28);
            this.timesBox.TabIndex = 4;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(15, 468);
            this.addEventButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(166, 32);
            this.addEventButton.TabIndex = 6;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "User Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(120, 9);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(206, 26);
            this.nameBox.TabIndex = 0;
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(187, 468);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(141, 32);
            this.addTaskButton.TabIndex = 14;
            this.addTaskButton.Text = "Add Task";
            this.addTaskButton.UseVisualStyleBackColor = true;
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 20;
            this.taskListBox.Location = new System.Drawing.Point(18, 321);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(310, 64);
            this.taskListBox.TabIndex = 15;
            this.taskListBox.SelectedIndexChanged += new System.EventHandler(this.taskBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Task Name:";
            // 
            // taskBox
            // 
            this.taskBox.Location = new System.Drawing.Point(113, 391);
            this.taskBox.Name = "taskBox";
            this.taskBox.Size = new System.Drawing.Size(214, 26);
            this.taskBox.TabIndex = 17;
            // 
            // clearTaskList
            // 
            this.clearTaskList.Location = new System.Drawing.Point(86, 423);
            this.clearTaskList.Name = "clearTaskList";
            this.clearTaskList.Size = new System.Drawing.Size(182, 38);
            this.clearTaskList.TabIndex = 18;
            this.clearTaskList.Text = "Clear Task List";
            this.clearTaskList.UseVisualStyleBackColor = true;
            // 
            // EventInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 513);
            this.Controls.Add(this.clearTaskList);
            this.Controls.Add(this.taskBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.timesBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventNameBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EventInfo";
            this.Text = "Add Event Form";
            this.Load += new System.EventHandler(this.EventInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eventNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox timesBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox taskBox;
        private System.Windows.Forms.Button clearTaskList;
    }
}
