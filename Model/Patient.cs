using System;

namespace Model
{
	public class Patient
	{
		public int PatientID { get; set; }
		public string PatientCode { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; }
		public string ContactNumber { get; set; }
		public string Address { get; set; }
		public string CivilStatus { get; set; }
		public string Occupation { get; set; }

		public string GuardianName { get; set; }
		public string GuardianRelationship { get; set; }
		public string GuardianContact { get; set; }
		public string GuardianAddress { get; set; }
		public bool GuardianPresent { get; set; }

		public string EmergencyContactName { get; set; }
		public string EmergencyContactNumber { get; set; }

		public bool IsFullyRegistered { get; set; } // NEW
		public bool IsActive { get; set; }
		public DateTime CreatedAt { get; set; }

		// Convenience property — "Last, First Middle" for grid display
		public string FullName
		{
			get
			{
				string middle = string.IsNullOrWhiteSpace(MiddleName) ? "" : " " + MiddleName;
				return LastName + ", " + FirstName + middle;
			}
		}

		// Convenience property — age computed from DOB
		public int Age
		{
			get
			{
				var today = DateTime.Today;
				int age = today.Year - DateOfBirth.Year;
				if (DateOfBirth.Date > today.AddYears(-age)) age--;
				return age;
			}
		}
	}
}