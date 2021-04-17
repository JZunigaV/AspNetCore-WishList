using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {


        private IActionResult Index()
        {
            return View("Index");
        }

        private IActionResult Error()
        {
            return View("Error");
        }

    }
}