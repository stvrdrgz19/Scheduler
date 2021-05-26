using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
	public class SqliteDataAccess
	{
		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}

		public static List<Appointment> LoadAppointments()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<Appointment>("SELECT Name, Phone_Number, Address, DateTime FROM Appointments ORDER BY Id DESC", new DynamicParameters());
				return output.ToList();
			}
		}

		public static void SaveAppointment(Appointment appointment)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("INSERT INTO Appointments (Name, Phone_Number, Address, DateTime) VALUES (@Name, @Phone_Number, @Address, @DateTime)", appointment);
			}
		}

		public static void UpdateAppointment(Appointment appointment, string dateTime, int Id)
		{
			//this needs to be updated to not use the Appointment class, instead just pass in dateTime and Id
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("UPDATE Appointments SET DateTime = '" + dateTime + "' WHERE Id = " + Id, appointment);
			}
		}
	}
}
