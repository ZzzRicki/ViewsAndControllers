using Microsoft.AspNetCore.Mvc;
using ViewsAndControllers.Models;

namespace ViewsAndControllers.Controllers
{
    public class LoanCalculatorController : Controller
    {
        public IActionResult Index()
        {
            LoanCalculatorModel lc = new();
            return View(lc);
        }

        [HttpPost]
        public IActionResult Calculate(LoanCalculatorModel lc)
        {
            if (ModelState.IsValid) 
            {
                var afterRate = lc.LoanAmount * lc.InterestRate / 100;
                var totalAmount = lc.LoanAmount + afterRate;
                var installment = totalAmount / lc.LoanTermMonths;
                lc.MonthlyPayment = Math.Round(installment, 2);
            }

            return View(nameof(Index), lc);
        }
    }
}
