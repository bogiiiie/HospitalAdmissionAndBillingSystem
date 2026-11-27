using System;

namespace Model
{
	public class Payment
	{
		public int PaymentID { get; set; }
		public string AdmissionCode { get; set; }
		public decimal AmountPaid { get; set; }
		public DateTime PaymentDate { get; set; }
		public string ProcessedBy { get; set; }
	}
}