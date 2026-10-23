using Microsoft.AspNetCore.Mvc;

namespace PruebaTecnica.Controllers
{
    public class ClientesControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
