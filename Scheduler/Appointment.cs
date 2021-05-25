using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
	public class Appointment
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Phone_Number { get; set; }
		public string Address { get; set; }
		public string DateTime { get; set; }

		public Appointment(string Name, string Phone_Number, string Address, string DateTime)
		{
			this.Name = Name;
			this.Phone_Number = Phone_Number;
			this.Address = Address;
			this.DateTime = DateTime;
		}
	}
}
