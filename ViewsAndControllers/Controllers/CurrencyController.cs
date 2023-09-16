using Microsoft.AspNetCore.Mvc;
using ViewsAndControllers.Models;

namespace ViewsAndControllers.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Index()
        {
            ConversionModel cm= new();
            return View(cm);
        }

        [HttpPost]
        public IActionResult Convert(ConversionModel cm)
        {
            if (ModelState.IsValid)
            {
                double resultado = ConvertCurrency(cm.From!, cm.To!, cm.Amount);
                cm.Result = Math.Round(resultado, 2);
            }

            return View(nameof(Index), cm);
        }

        private double ConvertCurrency(string from, string to, double amount)
        {
            double tasaCambioPesoDolar = 1.0 / 55.0; 
            double tasaCambioPesoEuro = 1.0 / 60.0;  
            double tasaCambioEuroDolar = 1.0 / 1.2; 

            if (from == "Peso" && to == "Dólar")
            {
                return amount * tasaCambioPesoDolar;
            }
            else if (from == "Peso" && to == "Euro")
            {
                return amount * tasaCambioPesoEuro;
            }
            else if (from == "Dólar" && to == "Peso")
            {
                return amount / tasaCambioPesoDolar;
            }
            else if (from == "Dólar" && to == "Euro")
            {
                return amount * tasaCambioEuroDolar;
            }
            else if (from == "Euro" && to == "Peso")
            {
                return amount / tasaCambioPesoEuro;
            }
            else if (from == "Euro" && to == "Dólar")
            {
                return amount / tasaCambioEuroDolar;
            }

            return amount;
        }
    }
}
