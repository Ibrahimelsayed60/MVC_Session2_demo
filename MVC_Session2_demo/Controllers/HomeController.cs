using Microsoft.AspNetCore.Mvc;

namespace MVC_Session2_demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Hello from content result";

            //return Redirect("/Home/AboutUs");

            return Content("Hello from content result");
        }

        public string AboutUs()
        {
            return "This is About us action";
        }
    }
}
