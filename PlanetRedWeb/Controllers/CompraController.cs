using Microsoft.AspNetCore.Mvc;

namespace PlanetRedWeb.Controllers
{
    public class CompraController : Controller
    {
        [HttpPost]
        public IActionResult FinalizarCompra(int cheia, int meia, int isento)
        {
            int total = (cheia * 50) + (meia * 25);

            // Lógica para processar a compra
            string message = $"Compra finalizada! Total: R$ {total},00.";

            ViewBag.Message = message;
            return View("ConfirmacaoCompra");
        }
    }
}

