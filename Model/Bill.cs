using System;

namespace Model
{
	public class Bill
	{
		public int BillID { get; set; }
		public string BillCode { get; set; }
		public string AdmissionCode { get; set; }

		public decimal RoomCharges { get; set; }
		public decimal TreatmentCharges { get; set; }

		public string DiscountType { get; set; }     // "Amount" or "Percentage"
		public decimal DiscountValue { get; set; }   // e.g., 20 (for 20%) or 500 (for ₱500)
		public string DiscountReason { get; set; }   // e.g., "Senior Citizen"
		public decimal DiscountComputed { get; set; } // e.g., 900 (the actual peso deduction)

		public decimal TotalDue { get; set; }
		public decimal AmountPaid { get; set; }
		public decimal Change { get; set; }

		public string Status { get; set; }           // "Draft" or "Paid"
		public string ProcessedBy { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}