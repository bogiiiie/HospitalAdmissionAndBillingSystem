using System;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class BillController
	{
		private readonly PaymentRepository paymentRepo = new PaymentRepository();
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

		// ==========================================
		// PROCESS BILL — Handles Partial Payments
		// ==========================================
		public string ProcessBill(Bill b, decimal newPayment)
		{
			if (b.TotalDue < 0)
				return "Invalid total due.";

			if (newPayment < 0)
				return "Payment cannot be negative.";

			decimal existingPaid = 0m;

			// Fetch existing bill to accumulate payments if this is an update
			if (!string.IsNullOrEmpty(b.BillCode))
			{
				var existingBill = repository.GetBillByAdmission(b.AdmissionCode);
				if (existingBill != null)
				{
					existingPaid = existingBill.AmountPaid;
				}
			}

			// Add the new payment to the existing payment
			decimal totalPaid = existingPaid + newPayment;

			b.AmountPaid = totalPaid;
			b.Balance = b.TotalDue - totalPaid;

			// Determine Status based on Balance
			if (b.Balance <= 0)
			{
				// Fully Paid (or Overpaid)
				b.Status = "Paid";
				b.Change = Math.Abs(b.Balance); // Change is the overpaid amount
				b.Balance = 0;                  // Force balance to zero
			}
			else
			{
				// Partially Paid
				b.Status = "Partially Paid";
				b.Change = 0;
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

			// Log the payment history if there is a new payment (This goes here!)
			if (newPayment > 0)
			{
				paymentRepo.AddPayment(new Model.Payment
				{
					AdmissionCode = b.AdmissionCode,
					AmountPaid = newPayment,
					PaymentDate = DateTime.Now,
					ProcessedBy = b.ProcessedBy
				});
			}

			return "OK";
		}
	}
}