using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
	public class Servico : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CabeamentoRede()
		{
			return View();
		}

		public IActionResult Iluminacao()
		{
			return View();
		}

		public IActionResult ProjetoEletrico()
		{
			return View();
		}
		
		public IActionResult SubstituicaoCabeamento()
		{
			return View();
		}
	}
}
