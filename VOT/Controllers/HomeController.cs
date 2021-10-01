using Microsoft.AspNetCore.Mvc;

namespace VOT.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}