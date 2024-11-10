using Microsoft.AspNetCore.Mvc;

namespace PlanetRedWeb.Controllers
{
    public class AvaliacaoController : Controller
    {
        [HttpPost]
        public IActionResult EnviarAvaliacao(int satisfacao1, int satisfacao2, int satisfacao3, int satisfacao4, int satisfacao5)
        {
            // Lógica para processar a avaliação
            string message = $"Avaliação enviada! Respostas: [{satisfacao1}, {satisfacao2}, {satisfacao3}, {satisfacao4}, {satisfacao5}].";

            ViewBag.Message = message;
            return View("ConfirmacaoAvaliacao");
        }
    }
}
