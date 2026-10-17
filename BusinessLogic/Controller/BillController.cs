using System;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class BillController
	{
		private readonly BillRepository repository = new BillRepository();
		private readonly AdmissionController admissionController = new AdmissionController();
		private readonly TreatmentController treatmentController = new TreatmentController();

		public Bill GetBill(string admissionCode)
		{
			return repository.GetBillByAdmission(admissionCode);
		}

		public string CalculateTotals(string admissionCode, string discountType, decimal discountValue, out decimal roomCharges, out decimal treatmentCharges, out decimal discountComputed, out decimal totalDue)
		{
			// Initialize all out parameters first to satisfy the compiler
			roomCharges = 0m;
			treatmentCharges = 0m;
			discountComputed = 0m;
			totalDue = 0m;

			if (string.IsNullOrWhiteSpace(admissionCode))
				return "No admission selected.";

			// Calculate the charges
			roomCharges = admissionController.CalculateRoomCharges(admissionCode, DateTime.Now);
			treatmentCharges = treatmentController.CalculateSubtotal(admissionCode);

			decimal subtotal = roomCharges + treatmentCharges;

			// Calculate the discount
			if (discountValue > 0)
			{
				if (discountType == "Percentage")
				{
					discountComputed = subtotal * (discountValue / 100m);
				}
				else
				{
					discountComputed = discountValue;
				}
			}

			// Validation check
			if (discountComputed > subtotal)
			{
				totalDue = subtotal; // Must assign a value before returning!
				return "Discount cannot exceed the total charges.";
			}

			// Final calculation
			totalDue = subtotal - discountComputed;
			return "OK";
		}

		public string ProcessBill(Bill b, bool isFinalize, decimal amountPaid)
		{
			if (b.TotalDue < 0)
				return "Invalid total due.";

			if (isFinalize)
			{
				if (amountPaid < b.TotalDue)
					return "Full payment is required to finalize the bill.";

				b.AmountPaid = amountPaid;
				b.Change = amountPaid - b.TotalDue;
				b.Status = "Paid";
			}
			else
			{
				// Save Draft
				b.AmountPaid = 0;
				b.Change = 0;
				b.Status = "Draft";
			}

			// If creating new
			if (string.IsNullOrEmpty(b.BillCode))
			{
				b.BillCode = repository.GenerateNextBillCode();
				repository.SaveBill(b, false);
			}
			else
			{
				repository.SaveBill(b, true);
			}

			return "OK";
		}
	}
}