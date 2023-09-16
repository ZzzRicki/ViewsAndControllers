using System.ComponentModel.DataAnnotations;
using ViewsAndControllers.Enums;

namespace ViewsAndControllers.Models
{
    public class LoanCalculatorModel
    {
        [Required(ErrorMessage = "El monto del préstamo es obligatorio.")]
        [Range(1, double.MaxValue, ErrorMessage = "El monto del préstamo debe ser mayor que 0.")]
        public double LoanAmount { get; set; }

        [Required(ErrorMessage = "Seleccionar el tipo de préstamo es obligatorio.")]
        public LoanType SelectedLoanType { get; set; }

        [Required(ErrorMessage = "Seleccionar el plazo en meses es obligatorio.")]
        [Range(12, 120, ErrorMessage = "El plazo debe estar entre 12 y 120 meses.")]
        public int LoanTermMonths { get; set; }
        public double InterestRate { get; set; }
        public double? MonthlyPayment { get; set; }
    }
}
