﻿namespace WebStore.Models
{
	public class Employee
	{
		public int Id { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string Patronymic { get; set; }
		public int Age { get; set; }

		public string Department { get; set; }
		public string Position { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}
