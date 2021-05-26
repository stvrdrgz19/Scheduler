namespace Scheduler
{
	partial class Scheduler
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnMaps = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.lvAppointments = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chDateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.dtFilter = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtTime = new System.Windows.Forms.DateTimePicker();
			this.btnSave = new System.Windows.Forms.Button();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.tbAddress = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbNotScheduled = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnMaps);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnEdit);
			this.groupBox1.Controls.Add(this.lvAppointments);
			this.groupBox1.Controls.Add(this.dtFilter);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = System.Drawing.Color.Blue;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(794, 270);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Appointments";
			// 
			// btnMaps
			// 
			this.btnMaps.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnMaps.Location = new System.Drawing.Point(168, 242);
			this.btnMaps.Name = "btnMaps";
			this.btnMaps.Size = new System.Drawing.Size(127, 23);
			this.btnMaps.TabIndex = 5;
			this.btnMaps.Text = "Open in Google Maps";
			this.btnMaps.UseVisualStyleBackColor = true;
			this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDelete.Location = new System.Drawing.Point(87, 242);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnEdit.Location = new System.Drawing.Point(6, 242);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 3;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// lvAppointments
			// 
			this.lvAppointments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPhone,
            this.chAddress,
            this.chDateTime});
			this.lvAppointments.FullRowSelect = true;
			this.lvAppointments.GridLines = true;
			this.lvAppointments.HideSelection = false;
			this.lvAppointments.Location = new System.Drawing.Point(7, 41);
			this.lvAppointments.Name = "lvAppointments";
			this.lvAppointments.Size = new System.Drawing.Size(780, 198);
			this.lvAppointments.TabIndex = 2;
			this.lvAppointments.UseCompatibleStateImageBehavior = false;
			this.lvAppointments.View = System.Windows.Forms.View.Details;
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 150;
			// 
			// chPhone
			// 
			this.chPhone.Text = "Phone Number";
			this.chPhone.Width = 130;
			// 
			// chAddress
			// 
			this.chAddress.Text = "Address";
			this.chAddress.Width = 300;
			// 
			// chDateTime
			// 
			this.chDateTime.Text = "DateTime";
			this.chDateTime.Width = 175;
			// 
			// dtFilter
			// 
			this.dtFilter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFilter.Location = new System.Drawing.Point(160, 17);
			this.dtFilter.Name = "dtFilter";
			this.dtFilter.Size = new System.Drawing.Size(89, 20);
			this.dtFilter.TabIndex = 1;
			this.dtFilter.ValueChanged += new System.EventHandler(this.dtFilter_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "View Appointments on or After:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbNotScheduled);
			this.groupBox2.Controls.Add(this.dtTime);
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.dtDate);
			this.groupBox2.Controls.Add(this.tbAddress);
			this.groupBox2.Controls.Add(this.tbPhone);
			this.groupBox2.Controls.Add(this.tbName);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.ForeColor = System.Drawing.Color.Blue;
			this.groupBox2.Location = new System.Drawing.Point(3, 280);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(794, 143);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add/Edit Appointments";
			// 
			// dtTime
			// 
			this.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtTime.Location = new System.Drawing.Point(195, 92);
			this.dtTime.Name = "dtTime";
			this.dtTime.ShowUpDown = true;
			this.dtTime.Size = new System.Drawing.Size(85, 20);
			this.dtTime.TabIndex = 9;
			// 
			// btnSave
			// 
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSave.Location = new System.Drawing.Point(7, 114);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dtDate
			// 
			this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDate.Location = new System.Drawing.Point(95, 92);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(95, 20);
			this.dtDate.TabIndex = 7;
			// 
			// tbAddress
			// 
			this.tbAddress.Location = new System.Drawing.Point(95, 67);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.Size = new System.Drawing.Size(693, 20);
			this.tbAddress.TabIndex = 6;
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(95, 42);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(693, 20);
			this.tbPhone.TabIndex = 5;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(95, 17);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(693, 20);
			this.tbName.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(8, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Date/Time:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(8, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(8, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Phone Number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(8, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name:";
			// 
			// cbNotScheduled
			// 
			this.cbNotScheduled.AutoSize = true;
			this.cbNotScheduled.Checked = true;
			this.cbNotScheduled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbNotScheduled.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbNotScheduled.Location = new System.Drawing.Point(287, 95);
			this.cbNotScheduled.Name = "cbNotScheduled";
			this.cbNotScheduled.Size = new System.Drawing.Size(116, 17);
			this.cbNotScheduled.TabIndex = 10;
			this.cbNotScheduled.Text = "Not Yet Scheduled";
			this.cbNotScheduled.UseVisualStyleBackColor = true;
			// 
			// Scheduler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 425);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Scheduler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exam Scheduler";
			this.Load += new System.EventHandler(this.Scheduler_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.ListView lvAppointments;
		private System.Windows.Forms.DateTimePicker dtFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMaps;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtTime;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chPhone;
		private System.Windows.Forms.ColumnHeader chAddress;
		private System.Windows.Forms.ColumnHeader chDateTime;
		private System.Windows.Forms.CheckBox cbNotScheduled;
	}
}

