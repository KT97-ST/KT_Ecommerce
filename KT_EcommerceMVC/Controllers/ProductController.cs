using Microsoft.AspNetCore.Mvc;

namespace KT_EcommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int? category)
        {
            return View();
        }
    }
}
