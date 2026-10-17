using System;
using System.Collections.Generic;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
	public class TreatmentController
	{
		private readonly TreatmentRepository repository = new TreatmentRepository();
		private readonly AdmissionController admissionController = new AdmissionController();

		public string AddTreatment(string admissionCode, string serviceName, int quantity, decimal unitCost, string recordedBy)
		{
			if (string.IsNullOrWhiteSpace(admissionCode))
				return "Please select an admission first.";

			// Validate admission is still active
			Admission adm = admissionController.GetAdmissionByCode(admissionCode);
			if (adm == null || adm.Status != "Admitted")
				return "Cannot add treatments to a discharged or inactive admission.";

			if (string.IsNullOrWhiteSpace(serviceName))
				return "Service name is required.";

			if (quantity <= 0)
				return "Quantity must be greater than zero.";

			if (unitCost < 0)
				return "Unit cost cannot be negative.";

			Treatment t = new Treatment
			{
				AdmissionCode = admissionCode,
				ServiceName = serviceName.Trim(),
				TreatmentDate = DateTime.Now,
				Quantity = quantity,
				UnitCost = unitCost,
				TotalCost = quantity * unitCost,
				RecordedBy = recordedBy
			};

			repository.AddTreatment(t);
			return "OK";
		}

		public List<Treatment> GetTreatments(string admissionCode)
		{
			return repository.GetTreatmentsByAdmission(admissionCode);
		}

		public decimal CalculateSubtotal(string admissionCode)
		{
			decimal total = 0m;
			foreach (var t in repository.GetTreatmentsByAdmission(admissionCode))
			{
				total += t.TotalCost;
			}
			return total;
		}
	}
}