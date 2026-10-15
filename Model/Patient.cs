using System;

namespace Model
{
	public class Patient
	{
		public int PatientID { get; set; }              // internal DB id (auto-increment)
		public string PatientCode { get; set; }         // display ID like "P-0001"
		public string FirstName { get; set; }
		public string MiddleName { get; set; }          // optional
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Gender { get; set; }              // Male / Female / Other
		public string ContactNumber { get; set; }
		public string Address { get; set; }             // optional
		public string CivilStatus { get; set; }         // optional
		public string Occupation { get; set; }          // optional

		// Guardian / emergency contact fields
		public string GuardianName { get; set; }
		public string GuardianRelationship { get; set; }
		public string GuardianContact { get; set; }
		public string GuardianAddress { get; set; }
		public bool GuardianPresent { get; set; }

		// Secondary emergency contact (optional)
		public string EmergencyContactName { get; set; }
		public string EmergencyContactNumber { get; set; }

		public bool IsActive { get; set; }              // true = active, false = deactivated
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