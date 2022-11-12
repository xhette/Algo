using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

namespace Algo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
