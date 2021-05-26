using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
	public partial class Scheduler : Form
	{
		public Scheduler()
		{
			InitializeComponent();
		}

		private static string dateToUpdate;
		private static bool isEdit = false;

		private void LoadAppointments()
		{
			lvAppointments.Items.Clear();
			List<Appointment> appointments = SqliteDataAccess.LoadAppointments();
			foreach (var appointment in appointments)
			{
				ListViewItem item1 = new ListViewItem(appointment.Name);
				item1.SubItems.Add(appointment.Phone_Number);
				item1.SubItems.Add(appointment.Address);
				item1.SubItems.Add(appointment.DateTime);
				lvAppointments.Items.Add(item1);
			}
		}

		private void Scheduler_Load(object sender, EventArgs e)
		{
			LoadAppointments();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			List<string> missingValues = new List<string>();
			if (String.IsNullOrWhiteSpace(tbName.Text))
			{
				missingValues.Add("Name");
			}
			if (String.IsNullOrWhiteSpace(tbPhone.Text))
			{
				missingValues.Add("Phone Number");
			}
			if (String.IsNullOrWhiteSpace(tbAddress.Text))
			{
				missingValues.Add("Address");
			}
			if (missingValues.Count != 0)
			{
				StringBuilder builder = new StringBuilder();
				foreach (string field in missingValues)
				{
					builder.Append(field.ToString()).AppendLine();
				}
				string message = "The following fields need to be filled out to save the appointment:\n\n" + builder.ToString();
				string caption = "MISSING VALUES";
				MessageBoxButtons buttons = MessageBoxButtons.OK;
				MessageBoxIcon icon = MessageBoxIcon.Error;

				MessageBox.Show(message, caption, buttons, icon);
				missingValues.Clear();
				return;
			}
			string dateTime = dtDate.Text + "-" + dtTime.Text;
			if (cbNotScheduled.Checked)
			{
				dateTime = null;
			}
			Appointment appointment = new Appointment(tbName.Text, tbPhone.Text, tbAddress.Text, dateTime);
			if (isEdit)
			{
				if (dateToUpdate == dtDate.Text + "-" + dtTime.Text)
				{
					string message = "The Date or Time for this Appointment wasn't updated. If you wish save the appointment without setting a date and time please check the \"Not Yet Scheduled\" checkbox and save again.";
					string caption = "DATE NOT SET";
					MessageBoxButtons buttons = MessageBoxButtons.OK;
					MessageBoxIcon icon = MessageBoxIcon.Error;
					MessageBox.Show(message, caption, buttons, icon);
					return;
				}
				//update this once UpdateAppointment is updated to not use the Appointment class, also create a method to retrieve the Id of the selected Appointment, and pass that in instead of 1
				SqliteDataAccess.UpdateAppointment(appointment, dateTime, 1);
				isEdit = false;
				return;
			}
			SqliteDataAccess.SaveAppointment(appointment);
			tbName.Text = "";
			tbPhone.Text = "";
			tbAddress.Text = "";
			dtDate.ResetText();
			dtTime.ResetText();
			LoadAppointments();
			return;
		}

		private void dtFilter_ValueChanged(object sender, EventArgs e)
		{
			//update the listview according to the new datetime filter value
			return;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			isEdit = true;
			dateToUpdate = dtDate.Text + "-" + dtTime.Text;
			//check to make sure there are any rows selected
			//check if there are multiple listview rows selected, only allow edit if a single row is selected
			//check if there is already information filled out in the text boxes
			//	if so, prompt the user asking if they want to clear out the existing values
			//load the selected appointment into each field
			return;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			//prompt the user asking if they're sure they want to delete the selected appointment
			return;
		}

		private void btnMaps_Click(object sender, EventArgs e)
		{
			//figure out how to work with the google maps api
			//check to make sure there are any rows selected
			//send out the address for the selected row(s)
			return;
		}
	}
}
