using System;

namespace Model
{
	public class Treatment
	{
		public int TreatmentID { get; set; }
		public string AdmissionCode { get; set; }
		public string ServiceName { get; set; }
		public DateTime TreatmentDate { get; set; }
		public int Quantity { get; set; }
		public decimal UnitCost { get; set; }
		public decimal TotalCost { get; set; }
		public string RecordedBy { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}