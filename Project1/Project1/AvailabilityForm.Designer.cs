namespace Project1
{
	/// <summary>
	/// Form for adding availability
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	partial class AvailabilityForm
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
			this.attendeeButton = new System.Windows.Forms.Button();
			this.eventsBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.addButton = new System.Windows.Forms.Button();
			this.timesBox = new System.Windows.Forms.ComboBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.addTask = new System.Windows.Forms.Button();
			this.selectTask = new System.Windows.Forms.ComboBox();
			this.tasksList = new System.Windows.Forms.ListBox();
			this.clearTasks = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// attendeeButton
			// 
			this.attendeeButton.Location = new System.Drawing.Point(114, 481);
			this.attendeeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.attendeeButton.Name = "attendeeButton";
			this.attendeeButton.Size = new System.Drawing.Size(123, 36);
			this.attendeeButton.TabIndex = 0;
			this.attendeeButton.Text = "Add Attendee";
			this.attendeeButton.UseVisualStyleBackColor = true;
			this.attendeeButton.Click += new System.EventHandler(this.attendeeButton_Click);
			// 
			// eventsBox
			// 
			this.eventsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.eventsBox.FormattingEnabled = true;
			this.eventsBox.Location = new System.Drawing.Point(114, 42);
			this.eventsBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.eventsBox.Name = "eventsBox";
			this.eventsBox.Size = new System.Drawing.Size(230, 28);
			this.eventsBox.TabIndex = 1;
			this.eventsBox.SelectedIndexChanged += new System.EventHandler(this.eventsBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Event:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "User Name:";
			// 
			// nameBox
			// 
			this.nameBox.Location = new System.Drawing.Point(114, 8);
			this.nameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(230, 26);
			this.nameBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Available Hours:";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(196, 80);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(133, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "24 hour mode";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(46, 115);
			this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(257, 124);
			this.listBox1.TabIndex = 7;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(194, 282);
			this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(110, 28);
			this.addButton.TabIndex = 8;
			this.addButton.Text = "Add Time";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// timesBox
			// 
			this.timesBox.Location = new System.Drawing.Point(25, 282);
			this.timesBox.Name = "timesBox";
			this.timesBox.Size = new System.Drawing.Size(138, 28);
			this.timesBox.TabIndex = 16;
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(110, 246);
			this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(123, 29);
			this.clearButton.TabIndex = 10;
			this.clearButton.Text = "Clear Times";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// addTask
			// 
			this.addTask.Location = new System.Drawing.Point(196, 446);
			this.addTask.Name = "addTask";
			this.addTask.Size = new System.Drawing.Size(107, 28);
			this.addTask.TabIndex = 20;
			this.addTask.Text = "Add Task";
			this.addTask.Click += new System.EventHandler(this.addTask_Click);
			// 
			// selectTask
			// 
			this.selectTask.Location = new System.Drawing.Point(25, 446);
			this.selectTask.Name = "selectTask";
			this.selectTask.Size = new System.Drawing.Size(138, 28);
			this.selectTask.TabIndex = 0;
			this.selectTask.SelectedIndexChanged += new System.EventHandler(this.selectTask_SelectedIndexChanged);
			// 
			// tasksList
			// 
			this.tasksList.FormattingEnabled = true;
			this.tasksList.ItemHeight = 20;
			this.tasksList.Location = new System.Drawing.Point(46, 317);
			this.tasksList.Name = "tasksList";
			this.tasksList.Size = new System.Drawing.Size(257, 84);
			this.tasksList.TabIndex = 17;
			this.tasksList.SelectedIndexChanged += new System.EventHandler(this.tasksList_SelectedIndexChanged);
			// 
			// clearTasks
			// 
			this.clearTasks.Location = new System.Drawing.Point(114, 407);
			this.clearTasks.Name = "clearTasks";
			this.clearTasks.Size = new System.Drawing.Size(119, 32);
			this.clearTasks.TabIndex = 19;
			this.clearTasks.Text = "Clear Tasks";
			this.clearTasks.UseVisualStyleBackColor = true;
			this.clearTasks.Click += new System.EventHandler(this.clearTasks_Click);
			// 
			// AvailabilityForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 521);
			this.Controls.Add(this.clearTasks);
			this.Controls.Add(this.tasksList);
			this.Controls.Add(this.selectTask);
			this.Controls.Add(this.addTask);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.timesBox);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.eventsBox);
			this.Controls.Add(this.attendeeButton);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "AvailabilityForm";
			this.Text = "Availability Form";
			this.Load += new System.EventHandler(this.AvailabilityForm_Load_1);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button attendeeButton;
		private System.Windows.Forms.ComboBox eventsBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.ComboBox timesBox;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button addTask;
		private System.Windows.Forms.ComboBox selectTask;
		private System.Windows.Forms.ListBox tasksList;
		private System.Windows.Forms.Button clearTasks;
	}
}
